namespace PasswordValidatorDecoratorLibrary
{
    public interface IPasswordValidator
    {
        bool IsValid();
        string ErrorMessage();

    }
}