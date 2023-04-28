namespace PasswordValidatorDecoratorLibrary
{
    public static class PasswordChecker
    {
 
        public static (bool,string) GetResponse(string password)
        {
            var checker = Init2(password);
            return (checker.IsValid(), checker.ErrorMessage());
        }

        private static IPasswordValidator Init(string password)
        {
            var passwordValidator = new PasswordValidator(password);
            var checkerLength = new MinLength(passwordValidator, password);
            var checkerNumbers = new AtLeastTwoNumbers(checkerLength, password);
            var checkerCapitalLetter = new AtLeastOneCapitalLetter(checkerNumbers, password);
            var checkerSpecialChars = new AtLeastOneSpecialChar(checkerCapitalLetter, password);
            return checkerSpecialChars;
        }



        private static IPasswordValidator Init2(string password)
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
