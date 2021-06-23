using System.Collections.Generic;

namespace ServicesLibrary.Validators.FormValidators
{
    public class ObjectNotNullValidator : BaseValidator
    {
        public ObjectNotNullValidator(int errorCode, ref List<int> errorCodes) : base(errorCode, ref errorCodes)
        {
        }

        public override bool RequestIsValid(object request)
        {
            return request != null;
        }
    }
}