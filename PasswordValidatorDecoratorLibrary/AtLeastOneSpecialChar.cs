namespace PasswordValidatorDecoratorLibrary;

internal class AtLeastOneSpecialChar : PasswordDecorator
{
    public AtLeastOneSpecialChar(IPasswordValidator passwordValidator, string password) : base(passwordValidator, password)
    {
        MyErrorMessage = "Password must be at least one special char";
    }


    protected override bool MyValidator() => Password.Any(x => !char.IsLetterOrDigit(x));

}