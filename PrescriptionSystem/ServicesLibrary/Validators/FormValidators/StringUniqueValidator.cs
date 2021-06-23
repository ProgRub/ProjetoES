using System;
using System.Collections.Generic;
using System.Linq;

namespace ServicesLibrary.Validators.FormValidators
{
    public class StringUniqueValidator : BaseValidator
    {
        private readonly IEnumerable<string> _stringsToCheck;

        public StringUniqueValidator(int errorCode, ref List<int> errorCodes, IEnumerable<string> stringsToCheck) :
            base(errorCode, ref errorCodes)
        {
            _stringsToCheck = stringsToCheck;
        }

        public override bool RequestIsValid(object request)
        {
            if (request is string requestString)
            {
                return _stringsToCheck.All(checkingString => requestString != checkingString);
            }

            throw new NotSupportedException($"Invalid type {request.GetType()}!");
        }
    }
}