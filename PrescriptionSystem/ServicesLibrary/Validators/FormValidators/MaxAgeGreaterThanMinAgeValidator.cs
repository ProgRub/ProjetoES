using System;
using System.Collections.Generic;

namespace ServicesLibrary.Validators.FormValidators
{
    public class MaxAgeGreaterThanMinAgeValidator : BaseValidator
    {
        public MaxAgeGreaterThanMinAgeValidator(int errorCode, ref List<int> errorCodes) : base(errorCode,
            ref errorCodes)
        {
        }

        public override bool RequestIsValid(object request)
        {
            if (request is Tuple<int, int>(var ageMaximum, var ageMinimum))
            {
                return ageMaximum >= ageMinimum;
            }

            throw new NotSupportedException($"Invalid type {request.GetType()}!");
        }
    }
}