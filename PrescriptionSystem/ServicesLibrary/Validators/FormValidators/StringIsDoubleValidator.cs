using System;
using System.Collections.Generic;

namespace ServicesLibrary.Validators.FormValidators
{
    public class StringIsDoubleValidator:BaseValidator
    {
        public StringIsDoubleValidator(int errorCode, ref List<int> errorCodes) : base(errorCode, ref errorCodes)
        {
        }

        public override bool RequestIsValid(object request)
        {

            if (request is string requestString)
            {
                return double.TryParse(requestString,out var number) && number > 0; ;
            }

            throw new NotSupportedException($"Invalid type {request.GetType()}!");
        }
    }
}