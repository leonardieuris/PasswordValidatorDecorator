namespace PasswordValidatorDecoratorLibrary
{
    public static class PasswordChecker
    {
 
        public static (bool,string) GetResponse(string password)
        {
            IPasswordValidator checker = Init(password);
            return (checker.IsValid(), checker.ErrorMessage());
        }


        private static IPasswordValidator Init(string password)
        {
            IPasswordValidator passwordValidator = new PasswordValidator(password);
            passwordValidator = new MinLength(passwordValidator, password);
            passwordValidator = new AtLeastTwoNumbers(passwordValidator, password);
            passwordValidator = new AtLeastOneCapitalLetter(passwordValidator, password);
            passwordValidator = new AtLeastOneSpecialChar(passwordValidator, password);
            return passwordValidator;
        }

    }
}
