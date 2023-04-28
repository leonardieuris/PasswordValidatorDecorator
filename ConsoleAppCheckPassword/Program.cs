using PasswordValidatorDecoratorLibrary;

var psw1 = "";
var psw2 = "pass";
var psw3 = "password";
var psw4 = "password1";
var psw5 = "Password1";
var psw6 = "Password1*";
var psw7 = "Password12*";

var passwordChecker = new PasswordChecker();

var response1 = passwordChecker.GetResponse(psw1);
var response2 = passwordChecker.GetResponse(psw2);
var response3 = passwordChecker.GetResponse(psw3);
var response4 = passwordChecker.GetResponse(psw4);
var response5 = passwordChecker.GetResponse(psw5);
var response6 = passwordChecker.GetResponse(psw6);
var response7 = passwordChecker.GetResponse(psw7);


Console.WriteLine("************************************");
Console.WriteLine($"psw1: {psw1} | isvalid: {response1.Item1} | messageError:{Environment.NewLine}{response1.Item2}");
Console.WriteLine("************************************");
Console.WriteLine($"psw2: {psw2} | isvalid: {response2.Item1} | messageError:{Environment.NewLine}{response2.Item2}");
Console.WriteLine("************************************");
Console.WriteLine($"psw3: {psw3} | isvalid: {response3.Item1} | messageError:{Environment.NewLine}{response3.Item2}");
Console.WriteLine("************************************");
Console.WriteLine($"psw4: {psw4} | isvalid: {response4.Item1} | messageError:{Environment.NewLine}{response4.Item2}");
Console.WriteLine("************************************");
Console.WriteLine($"psw5: {psw5} | isvalid:{response5.Item1} | messageError:{Environment.NewLine}{response5.Item2}");
Console.WriteLine("************************************");
Console.WriteLine($"psw6: {psw6} | isvalid {response6.Item1} | messageError:{Environment.NewLine}{response6.Item2}");
Console.WriteLine("************************************");
Console.WriteLine($"psw7: {psw7} | isvalid: {response7.Item1} | messageError:{Environment.NewLine}{response7.Item2}");