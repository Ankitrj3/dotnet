using System.Collections;
namespace Collections
{
    public class ArrayLis
    {
        public void OperationArray()
        {
            ArrayList al = new ArrayList();

            Console.WriteLine(al.Capacity);
            al.Add(1223);
            Console.WriteLine(al.Capacity);
            al.Add(12);
            al.Add(546);
            al.Add(78);
            al.Add(7896);
            Console.WriteLine(al.Capacity);

            foreach(Object obj in al)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            al.Insert(2,34566);

            foreach(Object obj in al)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();

            al.Remove(78);
            foreach(Object obj in al)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();

            al.RemoveAt(2);
            foreach(Object obj in al)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}