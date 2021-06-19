using System;
using System.Collections;
using System.Collections.Generic;
using ComponentsLibrary.Entities;
using ServicesLibrary.DifferentServices;

namespace ServicesLibrary.Validators.TherapySessionValidators
{
    public class PatientAvailabilityValidator : BaseValidator
    {
        public override object Validate(object requestListParameter)
        {
            var requestList = (List<object>) requestListParameter;
            var request = requestList[0];
            var errorCodes = (List<int>) requestList[1];
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
                            errorCodes.Add(Services.PatientUnavailable);
                            break;
                        }
                    }
                }

                requestList = new List<object> {request, errorCodes};
                return base.Validate(requestList) ?? errorCodes;
            }

            throw new NotSupportedException($"Invalid type {request.GetType()}!");
        }
    }
}