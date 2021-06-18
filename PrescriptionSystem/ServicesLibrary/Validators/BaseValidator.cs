using System.Collections.Generic;

namespace ServicesLibrary.Validators
{
    public abstract class BaseValidator:IValidator
    {

        private IValidator _nextValidator;
        private int _errorCode;
        private List<int> _errorCodes;

        protected BaseValidator(int errorCode,ref List<int> errorCodes)
        {
            _errorCode = errorCode;
            _errorCodes = errorCodes;
        }

        public IValidator SetNext(IValidator next)
        {
            _nextValidator = next;
            return _nextValidator;
        }
        public object Validate(object request)
        {
            if (!RequestIsValid(request))
            {
                _errorCodes.Add(_errorCode);
            }
            return _nextValidator?.Validate(request);
        }

        public abstract bool RequestIsValid(object request);
    }
}