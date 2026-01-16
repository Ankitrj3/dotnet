public class StackManager<T>
{
    private Stack<T> _stack = new Stack<T>();

    public T AddElement(T val)
    {
        _stack.Push(val);
        return val;
    }
    public T DeleteFromTop()
    {
        return _stack.Pop();
    }
    public T TopElement()
    {
        return _stack.Peek();
    }
    public void AllValues()
    {
        foreach(T t in _stack)
        {
            Console.Write(t + " ");
        }
        Console.WriteLine();
    }
}