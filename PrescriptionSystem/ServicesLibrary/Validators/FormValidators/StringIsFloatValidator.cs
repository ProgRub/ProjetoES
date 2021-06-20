using System;
using System.Collections.Generic;

namespace ServicesLibrary.Validators.FormValidators
{
    public class StringIsFloatValidator:BaseValidator
    {
        public StringIsFloatValidator(int errorCode, ref List<int> errorCodes) : base(errorCode, ref errorCodes)
        {
        }

        public override bool RequestIsValid(object request)
        {

            if (request is string requestString)
            {
                return float.TryParse(requestString,out _);
            }

            throw new NotSupportedException($"Invalid type {request.GetType()}!");
        }
    }
}