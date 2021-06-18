using System;
using System.Collections.Generic;
using System.Linq;

namespace ServicesLibrary.Validators.FormValidators
{
    public class ObjectUniqueValidator : BaseValidator
    {
        private IEnumerable<object> _objectsToCheck;

        public ObjectUniqueValidator(int errorCode, ref List<int> errorCodes, IEnumerable<object> objectsToCheck) :
            base(errorCode, ref errorCodes)
        {
            _objectsToCheck = objectsToCheck;
        }

        public ObjectUniqueValidator(int errorCode, ref List<int> errorCodes, IEnumerable<int> objectsToCheck) : base(errorCode, ref errorCodes)
        {
            _objectsToCheck = new List<object>();
            foreach (var i in objectsToCheck)
            {
                _objectsToCheck=_objectsToCheck.Append(i);
            }
        }

        public override bool RequestIsValid(object request)
        {
            foreach (var checkingObject in _objectsToCheck)
            {
                if (request == checkingObject)
                {
                    return false;
                }
            }

            return true;
        }
    }
}