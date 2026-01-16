namespace LocalFunctions
{
    public delegate void Method<T>(T t);
    public class GenericClass
    {
        public string? Name{get; set;}
        public int Id{get; set;}
        public string? Department{get; set;}
        public void Print()
        {
            Console.WriteLine(Name+" "+Id+" "+Department);
        }
    }
    public class Employee
    {
        public string? Name{get; set;}
        public int Id{get; set;}
        public string? Department{get; set;}
        public void Print()
        {
            Console.WriteLine(Name+" "+Id+" "+Department);
        }
    }
}