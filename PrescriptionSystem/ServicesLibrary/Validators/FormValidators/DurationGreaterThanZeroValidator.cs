using System;
using System.Collections.Generic;

namespace ServicesLibrary.Validators.FormValidators
{
    public class DurationGreaterThanZeroValidator : BaseValidator
    {
        public DurationGreaterThanZeroValidator(int errorCode, ref List<int> errorCodes) : base(errorCode,
            ref errorCodes)
        {
        }

        public override bool RequestIsValid(object request)
        {
            if (request is TimeSpan duration)
            {
                return duration > new TimeSpan(0, 0, 0);
            }

            throw new NotSupportedException($"Invalid type {request.GetType()}!");
        }
    }
}