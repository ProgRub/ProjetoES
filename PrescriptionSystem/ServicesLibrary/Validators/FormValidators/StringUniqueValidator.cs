using System;
using System.Collections.Generic;

namespace ServicesLibrary.Validators.FormValidators
{
    public class StringUniqueValidator : BaseValidator
    {
        private IEnumerable<string> _stringsToCheck;

        public StringUniqueValidator(int errorCode, ref List<int> errorCodes, IEnumerable<string> stringsToCheck) :
            base(errorCode, ref errorCodes)
        {
            _stringsToCheck = stringsToCheck;
        }

        public override bool RequestIsValid(object request)
        {
            if (request is string requestString)
            {
                foreach (var checkingString in _stringsToCheck)
                {
                    if (requestString == checkingString)
                    {
                        return false;
                    }
                }

                return true;
            }

            throw new NotSupportedException($"Invalid type {request.GetType()}!");
        }
    }
}