namespace Collections
{
    public class GenericList
    {
        public void genericVoid()
        {
            List<int> an = new List<int>();
            an.Add(12);
            an.Add(89);
            an.Add(34);

            foreach(int a in an)
            {
                Console.WriteLine(a);
            }
        }
    }
}