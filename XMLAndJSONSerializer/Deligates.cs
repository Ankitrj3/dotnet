namespace DeligatesFun
{
    public delegate int DelegateADDFunction(int a, int b);

    public class Deligates
    {
        public int a;
        public int b;

        public void DelegateEx1()
        {
            DelegateADDFunction delegateVariable = new DelegateADDFunction(AddMethod1);
            Console.WriteLine(delegateVariable(1,23));
        }
        private int AddMethod1(int a, int b)
        {
            return a+b+10;
        }
        private int AddMethod2(int a, int b)
        {
            return a+b;
        }
    }

}