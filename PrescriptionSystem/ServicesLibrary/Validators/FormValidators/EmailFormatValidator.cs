using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServicesLibrary.Validators.FormValidators
{
    public class EmailFormatValidator : BaseValidator
    {
        public EmailFormatValidator(int errorCode, ref List<int> errorCodes) : base(errorCode, ref errorCodes)
        {
        }

        public override bool RequestIsValid(object request)
        {
            if (request is string requestString)
            {
                return new EmailAddressAttribute().IsValid(requestString);
            }

            throw new NotSupportedException($"Invalid type {request.GetType()}!");
        }
    }
}