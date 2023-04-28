namespace PasswordValidatorDecoratorLibrary
{
    internal abstract class PasswordDecorator : IPasswordValidator
    {
        private readonly IPasswordValidator _passwordValidator;
        protected string _password;
        protected string MyErrorMessage;

        public PasswordDecorator(IPasswordValidator passwordValidator,string password)
        {
            _passwordValidator = passwordValidator;
            _password = password;
        }

        public bool IsValid() => _passwordValidator.IsValid() && MyValidator();

        public string ErrorMessage() =>
            !MyValidator() ? $"{_passwordValidator.ErrorMessage()}{Environment.NewLine}{MyErrorMessage}":_passwordValidator.ErrorMessage();
        


        protected abstract bool MyValidator();
        

    }
}
