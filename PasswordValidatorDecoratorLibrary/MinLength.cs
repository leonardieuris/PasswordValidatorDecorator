namespace PasswordValidatorDecoratorLibrary
{
    internal class MinLength : PasswordDecorator
    {
        public MinLength(IPasswordValidator passwordValidator,string password) : base(passwordValidator,password)
        {
            MyErrorMessage  = "Password must be at least 8 characters";
        }

        protected override bool MyValidator()
        {
            return _password.Length > 7;
        }

    }
}
