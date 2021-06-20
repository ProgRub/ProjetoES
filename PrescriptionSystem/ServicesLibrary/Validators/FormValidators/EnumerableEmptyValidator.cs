using System;
using System.Collections.Generic;
using System.Linq;

namespace ServicesLibrary.Validators.FormValidators
{
    public class EnumerableEmptyValidator:BaseValidator
    {
        public EnumerableEmptyValidator(int errorCode, ref List<int> errorCodes) : base(errorCode, ref errorCodes)
        {
        }

        public override bool RequestIsValid(object request)
        {

            if (request is IEnumerable<object> enumerable)
            {
                return enumerable.Any();
            }

            throw new NotSupportedException($"Invalid type {request.GetType()}!");
        }
    }
}