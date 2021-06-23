using System;
using System.Collections.Generic;
using ServicesLibrary.DTOs;

namespace ServicesLibrary.Validators.PrescriptionValidators
{
    public class StartDateIsBeforeEndDateValidator : BaseValidator
    {
        public StartDateIsBeforeEndDateValidator(int errorCode, ref List<int> errorCodes) : base(errorCode,
            ref errorCodes)
        {
        }

        public override bool RequestIsValid(object request)
        {
            if (request is PrescriptionDTO prescription)
            {
                return prescription.EndDate.Date >= prescription.StartDate.Date;
            }

            throw new NotSupportedException($"Invalid type {request.GetType()}!");
        }
    }
}