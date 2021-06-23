using System;
using System.Collections.Generic;

namespace ServicesLibrary.Validators.FormValidators
{
    public class StringIsIntegerValidator : BaseValidator
    {
        public StringIsIntegerValidator(int errorCode, ref List<int> errorCodes) : base(errorCode, ref errorCodes)
        {
        }

        public override bool RequestIsValid(object request)
        {
            if (request is string requestString)
            {
                return int.TryParse(requestString, out var integer) && integer >= 0;
            }

            throw new NotSupportedException($"Invalid type {request.GetType()}!");
        }
    }
}