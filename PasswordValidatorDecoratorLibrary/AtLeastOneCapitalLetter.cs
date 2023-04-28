namespace PasswordValidatorDecoratorLibrary;

internal class AtLeastOneCapitalLetter : PasswordDecorator
{
    public AtLeastOneCapitalLetter(IPasswordValidator passwordValidator,string password) : base(passwordValidator,password)
    {
        MyErrorMessage = "Password must be at least one capital letter";
    }

    protected override bool MyValidator() => _password.Any(x => char.IsUpper(x));

}