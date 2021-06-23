using System;
using System.Collections.Generic;

namespace ServicesLibrary.Validators.FormValidators
{
    public class StringEmptyValidator : BaseValidator
    {
        public StringEmptyValidator(int errorCode, ref List<int> errorCodes) : base(errorCode, ref errorCodes)
        {
        }

        public override bool RequestIsValid(object request)
        {
            if (request is string requestString)
            {
                return !string.IsNullOrWhiteSpace(requestString);
            }

            throw new NotSupportedException($"Invalid type {request.GetType()}!");
        }
    }
}