namespace PasswordValidatorDecoratorLibrary;

internal class AtLeastTwoNumbers : PasswordDecorator
{
    public AtLeastTwoNumbers(IPasswordValidator passwordValidator, string password) : base(passwordValidator, password)
    {
        MyErrorMessage = "Password must be at least two digit";
    }

    protected override bool MyValidator() => _password.Count(x => char.IsNumber(x)) > 1;
    
}