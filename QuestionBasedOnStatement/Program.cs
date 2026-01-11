using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using PersonImpl;
using EmployeeFeature;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.ServerSentEvents;
using Bill;
public class Program
{
    public static void Main(string[] args)
    {
        IList<Person> p = new List<Person>();
        p.Add(new Person { Name = "Ankit", Address = "LPU", Age = 22 });
        p.Add(new Person { Name = "Robin", Address = "LPU", Age = 25 });
        p.Add(new Person { Name = "Jack", Address = "LPU", Age = 23 });
        p.Add(new Person { Name = "Rocky", Address = "LPU", Age = 42 });
        p.Add(new Person { Name = "Ranjan", Address = "LPU", Age = 26 });

        PersonImplemaintation p2 = new PersonImplemaintation();
        string name = p2.GetName(p);
        Console.WriteLine(name);

        double AgeAverage = p2.Average(p);
        int MaxAge = p2.Max(p);
        Console.WriteLine(AgeAverage);
        Console.WriteLine(MaxAge);

        MethodOverloading m1 = new MethodOverloading();
        MethodOverloading m2 = new MethodOverloading();
        int an = m1.Add(9, 2, 23);
        double an1 = m2.Add(23.56, 45.453, 45);
        Console.WriteLine(an);
        Console.WriteLine(an1);

        // int [] arr = new int[4];
        // for(int i = 0; i < arr.Length; i++)
        // {
        //     int val = int.Parse(Console.ReadLine());
        //     arr[i] = val;
        // }
        // Array.Sort(arr);
        // for(int i = 0; i < arr.Length; i++)
        // {
        //     Console.Write(arr[i]+ " ");
        // }
        // Console.WriteLine();

        // int [,] ank = new int[2,5];
        // for(int i = 0; i < 2; i++)
        // {
        //     for(int j = 0; j < 5; j++)
        //     {
        //         int val = int.Parse(Console.ReadLine());
        //         ank[i, j] = val;
        //     }
        // }
        // for(int i = 0; i < 2; i++)
        // {
        //     for(int j = 0; j < 5; j++)
        //     {
        //         Console.Write(ank[i,j]+" ");
        //     }
        // }
        // Console.WriteLine();

        // // Boxing And UnBoxing
        // int num = 10;
        // Object obj = num;
        // Console.WriteLine(obj);

        // // UnBoxing 
        // Object num2 = 12332;
        // Console.WriteLine(num2);
        // int val = (int)num2;
        // Console.WriteLine(val);

        // // jagad Array
        // int [][] jag = new int[3][]
        // {
        //     new int[]{1,2},
        //     new int[]{12,67,89},
        //     new int[]{12,324,523,23}
        // };
        // for(int i = 0; i < jag.Length; i++)
        // {
        //     for(int j = 0; j < jag[i].Length; j++)
        //     {
        //         Console.Write(jag[i][j]+" ");
        //     }
        //     Console.WriteLine();
        // }

        // is and as

        Object obj = "ankit ranjan";
        if (obj is int)
        {
            Console.WriteLine("yes this is int");
        }
        else
        {
            Console.WriteLine("Unknown types");
        }

        string name1 = obj as string;
        if (name1 == null)
        {
            Console.WriteLine("Not Converted in string");
        }
        else
        {
            Console.WriteLine("Converted in string");
        }

        // ref and out

        RefAndOut rf = new RefAndOut();
        int resRef = 10;
        int resOut;

        rf.methodRef(ref resRef);
        Console.WriteLine("We need to Assign the value Before passing in method " + resRef);

        rf.methodOut(out resOut);
        Console.WriteLine("Without assinging the value it is working " + resOut);

        // Scenario 1: Object Comparison (Reference Equality)
        Object ob = "ankit ranjan";
        Object ob1 = ob;
        // We create a NEW string object with the same content
        Object ob2 = new string("ankit ranjan".ToCharArray());

        Console.WriteLine((ob == ob1) ? "Equal" : "Not Equal");      // Equal (Same reference)
        Console.WriteLine((ob == ob2) ? "Equal" : "Not Equal");      // Not Equal (Different references)
        Console.WriteLine(ob.Equals(ob2) ? "Equal" : "Not Equal");  // Equal (Content is the same)

        Console.WriteLine("---");

        // Scenario 2: String Comparison (Value Equality)
        string of = "ankit ranjan";
        string of1 = of;
        string of2 = new string("ankit ranjan".ToCharArray());

        // String operator == is "overloaded" to check content, not just reference
        Console.WriteLine((of == of1) ? "Equal" : "Not Equal");      // Equal
        Console.WriteLine((of == of2) ? "Equal" : "Not Equal");      // Equal
        Console.WriteLine(of.Equals(of2) ? "Equal" : "Not Equal");  // Equal

        List<Employee> employees = new List<Employee>()
        {
            new Employee("Ankit", 101, "Engineer", 25000),
            new Employee("Likhitha", 102, "Engineer", 55000),
            new Employee("Ranjan", 103, "Engineer", 45000)
        };

        EmployeeService service = new EmployeeService();

        Console.WriteLine("Names: " + service.GetAllEmployeeNames(employees));
        Console.WriteLine("Max Salary: " + service.GetMaxSalary(employees));
        Console.WriteLine("Second Max: " + service.SecondMaxSalary(employees));
        Console.WriteLine("Average Salary: " + service.GetAverageSalary(employees));

        GenericCalculator<int> gn = new GenericCalculator<int>();
        Console.WriteLine(gn.Add(12, 34));

        LMS lms = new LMS();
        lms.AddBook(new Book(12, "C++", "Ankit Ranjan", 25));
        lms.AddBook(new Book(111, "CSS", "Ankit Ranjan", 25));
        lms.AddBook(new Book(13, "C#", "Alla Likhitha Sri", 45));
        lms.AddBook(new Book(14, "C", "Robin", 45));
        lms.AddBook(new Book(15, "JAVA", "Ananaya", 25));
        lms.AddBook(new Book(16, "HTML", "Sumit", 20));

        Console.WriteLine(lms.GetTotalBooks());
        List<Book> books = lms.GetBooksByAuthor("Ankit Ranjan");

        Console.WriteLine("Books Written By Ankit Ranjan");
        foreach (Book b in books)
        {
            Console.WriteLine(b.BookId + " " + b.BookName);
        }

        BillingService bs = new BillingService();
        bs.AddTaxRate(Category.Electronics, 18);
        bs.AddTaxRate(Category.Food, 12);
        bs.AddTaxRate(Category.Clothing, 5);

        List<Item> items = new List<Item>()
        {
          new Item{ItemName = "Laptop",category = Category.Electronics, Quantity = 2, price = 50000.00},
          new Item{ItemName = "T Shirt",category = Category.Clothing, Quantity = 5, price = 200},
        };
        bs.CalculateBill(items);
        StackManager<int> stack = new StackManager<int>();
        Console.WriteLine(stack.AddElement(12));
        Console.WriteLine(stack.AddElement(14));
        Console.WriteLine(stack.AddElement(23));
        Console.WriteLine(stack.AddElement(1566));
        Console.WriteLine(stack.AddElement(783));
        stack.AllValues();
        Console.WriteLine(stack.TopElement());
        Console.WriteLine(stack.DeleteFromTop());
        Console.WriteLine(stack.TopElement());
        Console.WriteLine(stack.DeleteFromTop());
        Console.WriteLine(stack.TopElement());
        stack.AllValues();

        StudentAnalyzer sa = new StudentAnalyzer();
        IList<Student> students = new List<Student>()
        {
            new Student{RollNo=1,Name="ankit",Marks=55},
            new Student{RollNo=2,Name="ankit1",Marks=35},
            new Student{RollNo=3,Name="ankit2",Marks=45},
            new Student{RollNo=4,Name="ankit3",Marks=15},
            new Student{RollNo=5,Name="ankit4",Marks=25},
        };
        Student top = sa.GetTopper(students);
        IList<Student> res = sa.GetPassedStudents(students);

        foreach (Student s in res)
        {
            Console.WriteLine(s.Name + " " + s.RollNo + " " + s.Marks);
        }

        Console.WriteLine("TOpper of LPU " + top.Name + " " + top.RollNo + " " + top.Marks);


        BankService bs1 = new BankService();
        bs1.AddBankAccount(new Bank{AccountNo="121",AccountHolder="ankit",Balance=5000});
        bs1.Deposit("121",4000);
        bs1.WithDraw("121",3000);

    }
}