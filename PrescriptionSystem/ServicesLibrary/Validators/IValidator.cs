namespace ServicesLibrary.Validators
{
    public interface IValidator
    {
        IValidator SetNext(IValidator checker);
        object Validate(object request);
    }
}