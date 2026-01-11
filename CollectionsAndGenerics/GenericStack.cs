namespace Collections
{
    public class GenericStack<T>
    {
        public Stack<T> stack = new Stack<T>();
        public void AddStack(T value)
        {
            stack.Push(value);
        }
        public void DeleteTop()
        {
            Console.WriteLine(stack.Pop());
        }
        public void Top()
        {
            if(stack.Count < 1)
            {
                Console.WriteLine("No element is present");
            }
            else
            {
                Console.WriteLine(stack.Peek());
            }
            
        }
        public void Display()
        {
            foreach(T s in stack)
            {
                Console.Write(s+" ");
            }
            Console.WriteLine();
        }
    }
}