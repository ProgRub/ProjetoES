using System;
using System.Collections.Generic;
using ComponentsLibrary.Entities;
using ServicesLibrary.DTOs;

namespace ServicesLibrary.Validators.FormValidators
{
    public class TherapistOldEnoughValidator:BaseValidator
    {
        public TherapistOldEnoughValidator(int errorCode, ref List<int> errorCodes) : base(errorCode, ref errorCodes)
        {
        }

        public override bool RequestIsValid(object request)
        {
            if (request is TherapistDTO therapist)
            {
                return (DateTime.Today - therapist.DateOfBirth).Days >= 22 * 365.75;
            }

            throw new NotSupportedException($"Invalid type {request.GetType()}!");
        }
    }
}