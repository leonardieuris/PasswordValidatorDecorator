namespace PasswordValidatorDecoratorLibrary
{
    internal abstract class PasswordDecorator : IPasswordValidator
    {
        private readonly IPasswordValidator _passwordValidator;
        protected readonly string Password;
        protected string MyErrorMessage = string.Empty;

        protected PasswordDecorator(IPasswordValidator passwordValidator,string password)
        {
            _passwordValidator = passwordValidator;
            Password = password;
        }

        public bool IsValid() => _passwordValidator.IsValid() && MyValidator();

        public string ErrorMessage() =>
            !MyValidator() ? $"{_passwordValidator.ErrorMessage()}{Environment.NewLine}{MyErrorMessage}":_passwordValidator.ErrorMessage();
        


        protected abstract bool MyValidator();
        

    }
}
