using ExtensionMethod;
public class Program
{
    public static void Main(string[] args)
    {
        string a = "poop";
        string res = a.CheckPalindromeRes() ? "Palindrome" : "Not Palindrome" ;
        Console.WriteLine(res);
    }
}