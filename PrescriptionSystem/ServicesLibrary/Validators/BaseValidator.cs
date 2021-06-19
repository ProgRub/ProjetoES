namespace ServicesLibrary.Validators
{
    public abstract class BaseValidator:IValidator
    {

        private IValidator _nextValidator;
        public void SetNext(IValidator next)
        {
            _nextValidator = next;
        }
        public virtual object Validate(object request)
        {
            return _nextValidator?.Validate(request);
        }
    }
}