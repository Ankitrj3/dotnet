using CustomException;

public class DivideCustomException
{
    public void Divide(int a, int b)
    {
        if(b == 0){
            throw new CustomException1("Internal Server error");
        }
        int res = a/b;
        Console.WriteLine(res);
    }
}