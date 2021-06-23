using System;
using System.Collections.Generic;

namespace ServicesLibrary.Validators.FormValidators
{
    public class StringLengthValidator : BaseValidator
    {
        private readonly int _minimumLength;
        private readonly int _maximumLength;

        public StringLengthValidator(int errorCode, ref List<int> errorCodes, int minimumLength, int maximumLength) :
            base(errorCode, ref errorCodes)
        {
            _minimumLength = minimumLength;
            _maximumLength = maximumLength;
        }

        public override bool RequestIsValid(object request)
        {
            if (request is string requestString)
            {
                return requestString.Length >= _minimumLength && requestString.Length <= _maximumLength;
            }

            throw new NotSupportedException($"Invalid type {request.GetType()}!");
        }
    }
}