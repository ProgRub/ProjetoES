using System;
using System.Collections.Generic;
using ServicesLibrary.DifferentServices;
using ServicesLibrary.DTOs;

namespace ServicesLibrary.Validators.TherapySessionValidators
{
    public class TherapistAvailabilityValidator : BaseValidator
    {
        public TherapistAvailabilityValidator(int errorCode, ref List<int> errorCodes) : base(errorCode, ref errorCodes)
        {
        }

        public override bool RequestIsValid(object request)
        {
            if (request is TherapySessionDTO therapySession)
            {
                var patientTherapySessions =
                    TherapySessionService.Instance.GetAllTherapySessionsOfTherapist(therapySession.Therapist.Id);
                foreach (var therapySessionInDatabase in patientTherapySessions)
                {
                    if (therapySession.DateTime.Date != therapySessionInDatabase.DateTime.Date) continue;

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

                return true;
            }

            throw new NotSupportedException($"Invalid type {request.GetType()}!");
        }
    }
}