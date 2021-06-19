using System.Collections.Generic;

namespace ServicesLibrary.Validators.Prescription
namespace ServicesLibrary.Validators.PrescriptionValidators
{
    public class TimeConstraintsValidator : BaseValidator
    {
        public TimeConstraintsValidator(int errorCode, ref List<int> errorCodes) : base(errorCode, ref errorCodes)
        {
        }

        public override bool RequestIsValid(object request)
        {
            throw new System.NotImplementedException();
        }
    }
}