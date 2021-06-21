using System;
using System.Collections.Generic;
using System.Linq;
using ServicesLibrary.DTOs;

namespace ServicesLibrary.Validators.FormValidators
{
    public class MaxAgeGreaterThanMinAgeValidator : BaseValidator
    {
        public MaxAgeGreaterThanMinAgeValidator(int errorCode, ref List<int> errorCodes) : base(errorCode, ref errorCodes)
        {
        }

        public override bool RequestIsValid(object request)
        {
            if (request is Tuple<string, string> tuple)
            {
                if (!int.TryParse(tuple.Item1, out var ageMaximum)) return false;
                if (!int.TryParse(tuple.Item2, out var ageMinimum)) return false;

                return ageMaximum >= ageMinimum;
            }

            throw new NotSupportedException($"Invalid type {request.GetType()}!");
        }
    }
}