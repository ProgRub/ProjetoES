using System;
using System.Collections.Generic;
using System.Linq;
using ComponentsLibrary.Entities;

namespace ServicesLibrary.Validators.FormValidators
{
    public class EnumerableNotEmptyValidator : BaseValidator
    {
        public EnumerableNotEmptyValidator(int errorCode, ref List<int> errorCodes) : base(errorCode, ref errorCodes)
        {
        }

        public override bool RequestIsValid(object request)
        {
            switch (request)
            {
                case IEnumerable<BodyPart> enumEnumerable:
                    return enumEnumerable.Any();
                case IEnumerable<object> enumerable:
                    return enumerable.Any();
                default:
                    throw new NotSupportedException($"Invalid type {request.GetType()}!");
            }
        }
    }
}