namespace PasswordValidatorDecoratorLibrary
{
    public class PasswordChecker
    {
        public PasswordChecker()
        {
            
        }

        public (bool,string) GetResponse(string password)
        {
            var checker = Init(password);
            return (checker.IsValid(), checker.ErrorMessage());
        }

        private IPasswordValidator Init(string password)
        {
            var passwordValidator = new PasswordValidator(password);
            var checkerLength = new MinLength(passwordValidator, password);
            var checkerNumbers = new AtLeastTwoNumbers(checkerLength, password);
            var checkerCapitalLetter = new AtLeastOneCapitalLetter(checkerNumbers, password);
            var checkerSpecialChars = new AtLeastOneSpecialChar(checkerCapitalLetter, password);
            return checkerSpecialChars;
        }

    }
}
