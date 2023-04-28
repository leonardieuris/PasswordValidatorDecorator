namespace PasswordValidatorDecoratorLibrary;

internal class AtLeastOneSpecialChar : PasswordDecorator
{
    public AtLeastOneSpecialChar(IPasswordValidator passwordValidator, string password) : base(passwordValidator, password)
    {
        MyErrorMessage = "Password must be at least one special char";
    }

    private readonly List<char> specialChars = new List<char>(){
        '*',
        '+',
        '£',
        '$',
        '%',
        '?',
        '-',
        '_',
        '.',
        ':',
        ',',
        ';',
        '^',
        '#',
        '{',
        '}',
        '(',
        ')'
    };

    protected override bool MyValidator() => _password.Any(x => specialChars.Contains(x));

 


}