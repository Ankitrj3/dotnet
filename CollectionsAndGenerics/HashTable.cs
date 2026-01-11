using System.Collections;
namespace Collections
{
    public class HashTable
    {
        public void HashTableOperations()
        {
            Hashtable th = new Hashtable();
            th.Add("sadja","!@3234");
            th.Add("231","sfbkaf");

            foreach(Object key in th.Keys)
            {
                Console.WriteLine(key + " " +th[key]);
            }
        }
        
    }
}