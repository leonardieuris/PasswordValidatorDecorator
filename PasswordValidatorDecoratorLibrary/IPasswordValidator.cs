namespace PasswordValidatorDecoratorLibrary
{
    internal interface IPasswordValidator
    {
        bool IsValid();
        string ErrorMessage();
    }
}