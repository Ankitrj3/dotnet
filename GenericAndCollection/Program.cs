using GenericCollection;
using LocalGenericCollection;
using LocalFunctions;

public class Program
{
    public static void Main(string[] args)
    {
        MyGenericClass<Student> myGlobalType = new MyGenericClass<Student>();
        Student obj = new UGStudent();
        string Result = myGlobalType.GetTypeOfStudent(obj);
        Console.WriteLine(Result);
        string TypeMessage = myGlobalType.GetTypeMessage(obj);
        Console.WriteLine(TypeMessage);

        GenericClass g = new GenericClass
        {
            Name = "Ankit",
            Id = 1,
            Department = "IT"
        };

        Employee e = new Employee
        {
            Name = "Rahul",
            Id = 2,
            Department = "HR"
        };
        Method<GenericClass> d1 = obj => obj.Print();
        Method<Employee> d2 = obj => obj.Print();
        d1(g);
        d2(e);

        var number = 134;
        Predicate<int> isEven = number => number % 2 == 0;
        bool check = isEven(number);
        Console.WriteLine(check);
        
        Run();

        Func<int,int,string> multiplyResult = (x,y) =>
        {
            return $"{x} times {y} is {x*y}";  
        };
        string resultText = multiplyResult(5,4);
        Console.WriteLine(resultText);
    }
    public static void Run()
    {
        Action<string> logger = message =>
        {
          Console.WriteLine($"[LOG]: {message} at {DateTime.Now}");  
        };
        logger = message =>
        {
          Console.WriteLine($"[LOG]: {message.ToUpper()} at {DateTime.Now}");  //overridding the logger method 
        };
        logger("Application Started");
        
    }
}