namespace PasswordValidatorDecoratorLibrary
{
    internal class PasswordValidator : IPasswordValidator
    {
        private readonly string _password;

        public PasswordValidator(string password)
        {
            _password = password;
        }
        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(_password);
        }

        public string ErrorMessage() => IsValid() ? string.Empty : "Password is Empty";

    }
}
