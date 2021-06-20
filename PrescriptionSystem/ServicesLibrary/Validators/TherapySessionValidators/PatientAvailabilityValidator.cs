using System;
using System.Collections.Generic;
using ComponentsLibrary.Entities;
using ServicesLibrary.DifferentServices;

namespace ServicesLibrary.Validators.TherapySessionValidators
{
    public class PatientAvailabilityValidator : BaseValidator
    {
        public PatientAvailabilityValidator(int errorCode, ref List<int> errorCodes) : base(errorCode, ref errorCodes)
        {
        }
        public override bool RequestIsValid(object request)
        {
            if (request is TherapySession therapySession)
            {
                var patientTherapySessions =
                    TherapySessionService.Instance.GetAllTherapySessionsOfPatient(therapySession.Patient);
                foreach (var therapySessionInDatabase in patientTherapySessions)
                {
                    if (therapySession.DateTime.Date == therapySessionInDatabase.DateTime.Date)
                    {
                        var startTimeInDatabase = therapySessionInDatabase.DateTime.TimeOfDay;
                        var endTimeInDatabase = startTimeInDatabase + therapySessionInDatabase.EstimatedDuration;
                        var startTimeChecking = therapySession.DateTime.TimeOfDay;
                        var endTimeChecking = startTimeChecking + therapySession.EstimatedDuration;
                        if ((startTimeChecking >= startTimeInDatabase && startTimeChecking <= endTimeInDatabase) ||
                            (endTimeChecking <= endTimeInDatabase && endTimeChecking >= startTimeInDatabase))
                        {
                            return false;
                        }
                    }
                }

                return true;
            }

            throw new NotSupportedException($"Invalid type {request.GetType()}!");
        }
    }
}