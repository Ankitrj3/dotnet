public class Program
{
    public static void Main()
    {
        PG student = new PG(
            name: "Ankit",
            reg_no: 101,
            school: "ABC School",
            college: "XYZ Engineering College",
            department: "Computer Science"
        );

        Console.WriteLine("---- Student Details ----");
        Console.WriteLine($"Name       : {student.Name}");
        Console.WriteLine($"Reg No     : {student.Reg_no}");
        Console.WriteLine($"School     : {student.School}");
        Console.WriteLine($"College    : {student.College}");
        Console.WriteLine($"Department : {student.Department}");

        Oops.ConstructorOverloading co = new Oops.ConstructorOverloading();
        Oops.ConstructorOverloading co1 = new Oops.ConstructorOverloading(
            12000999
        );
        Console.WriteLine(co1.id);
        try{
        Oops.ConstructorOverloading co2 = new Oops.ConstructorOverloading(
            12233444,
            "Shashi Mani IDIOT"
        );
        Console.WriteLine(co2.id+" "+co2.name);
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Oops.ConstructorOverloading co3 = new Oops.ConstructorOverloading(
            12000777,
            "ANkit Ranjan",
            ".Net,JAVA"
        );
        Console.WriteLine(co3.id+" "+co3.name+" "+co3.requirement);

        Oops.ConstructorOverloading1 op1 = new Oops.ConstructorOverloading1();
        Oops.ConstructorOverloading1 op2 = new Oops.ConstructorOverloading1(12, 34);


    }

}
