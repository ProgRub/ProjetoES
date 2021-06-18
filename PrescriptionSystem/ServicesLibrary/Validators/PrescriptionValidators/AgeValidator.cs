
using System.Collections.Generic;
using ServicesLibrary.Validators.Prescription;

namespace ServicesLibrary.Validators.PrescriptionValidators
{
    public class AgeValidator:BaseValidator
    {

        public AgeValidator(int errorCode, ref List<int> errorCodes) : base(errorCode, ref errorCodes)
        {
        }

        public override bool RequestIsValid(object request)
        {
            throw new System.NotImplementedException();
        }
    }
}