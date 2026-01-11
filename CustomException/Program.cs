using CustomException;
public class Program
{
    public static void Main(string [] args)
    {
        try
        {
            int result = Divide(12,0);
            Console.WriteLine(result);
        }
        catch(AppCustomException1 ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            DivideCustomException d = new DivideCustomException();
            d.Divide(12,0);
        }catch(CustomException1 ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public static int Divide(int a,int b)
    {
        try
        {
            return a/b;
        }
        catch
        {
            throw new AppCustomException1();
        }
    }

}