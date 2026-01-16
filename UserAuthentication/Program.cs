public class UserAuthentication
{
    public string? Name { get; set; }
    public string? Password { get; set; }
    public string? ConfirmPassword { get; set; }
    public UserAuthentication()
    {

    }
    public UserAuthentication(string name, string password, string confirmPassword)
    {
        Name = name;
        Password = password;
        ConfirmPassword = confirmPassword;
    }

}
public class PasswordMismatchException : Exception
{
    public override string Message => "Password entered does not match.";
}
public class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter UserName");
            string? Name = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string? Password = Console.ReadLine();
            Console.WriteLine("Enter The Confirm Password");
            string? ConfirmPassword = Console.ReadLine();

            ValidatePassword(Name,Password,ConfirmPassword);
        }
        catch (PasswordMismatchException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public static void ValidatePassword(string name, string password, string confirmationPassword)
    {
        string? UserName = name.ToLower().Trim();
        string? Password = password.Trim();
        string? ConfirmPassword = confirmationPassword.Trim();

        if (Password != ConfirmPassword)
        {
            throw new PasswordMismatchException();
        }
        Console.WriteLine("Registered Successfully.");
    }
}
