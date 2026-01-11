using System.Collections.Generic;

namespace Collections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            ArrayLis al = new();
            al.OperationArray();
            
            HashTable ht = new();
            ht.HashTableOperations();
            
            GenericList gl = new();
            gl.genericVoid();

            Generic1 gn = new();
            gn.Add<int?>(12, 34);
            gn.Add<float?>(12.2f, 56.4f);
            gn.Add<double?>(12.3434, 23.567);
            gn.Sub<int?>(65, 32);
            gn.Sub<float?>(45.3f, 7.5f);
            gn.Sub<double?>(342.453, 56.342);

            DictionaryGeneric<int?, string?> dc = new DictionaryGeneric<int?, string?>();
            dc.AddItem(1, "Aman Kumar");

            GenericStack<int?> stack = new GenericStack<int?>();
            stack.AddStack(123);
            stack.AddStack(23);
            stack.AddStack(78);
            stack.AddStack(346);
            stack.AddStack(90);
            stack.Display();

            stack.DeleteTop();
            stack.Display();

            stack.Top();
        }  
    }
}