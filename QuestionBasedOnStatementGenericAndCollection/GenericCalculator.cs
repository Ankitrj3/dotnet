public class GenericCalculator<T>
{
    public T Add(T a, T b)
    {
        dynamic x = a;
        dynamic y = b;
        return x+y;
    }
    public T Sub(T a, T b)
    {
        dynamic x = a;
        dynamic y = b;
        return x - y;
    }
}