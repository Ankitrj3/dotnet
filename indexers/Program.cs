namespace Ankit
{
    public class Program
    {
        public static void Main(String [] args)
        {
            IndexerImpl ind = new IndexerImpl();
            ind[0] = "C++";
            ind[1] = "C#";
            ind[2] = "Java";

            Console.WriteLine("First Language "+ind[0]);
            Console.WriteLine("Second Language "+ind[1]);
            Console.WriteLine("Third Language "+ind[2]);

            Students s1 = new Students("LPU"){RollNo = 1, Name = "Ankit"};
            Students s2 = new Students(){RollNo = 2, Name = "Shashi"};
            Students s3 = new Students(){RollNo = 3, Name = "Likhitha"};
            Students s4 = new Students(){RollNo = 4, Name = "Sumit"};

            // Setting address using method for s2, s3, s4
            s2.SetAddress("LPU");
            s3.SetAddress("LPU");
            s4.SetAddress("LPU");

            s1.setPersonalId(1223434);
            s2.setPersonalId(145);
            s3.setPersonalId(54767);
            s4.setPersonalId(067945);

            s1[0] = "JAVA BOOK";
            

            s2[0] = "C# BOOK";
            s2[1] = ".NET BOOK";
            s3[2] = "C++ BOOK";

            s3[0] = "DATA STRUCTURE BOOK";
            s3[1] = "GO LANG BOOK";

            s4[0] = "SPRING BOOT BOOK";
            s4[1] = "NETWORKING BOOK";


            Console.WriteLine("---------Details of Students--------");
            Console.WriteLine("Student first details:");
            Console.WriteLine("Student Name: "+s1.Name+" Student RollNo: "+s1.RollNo+" Address: "+s1.GetAddress()+" Student Taken Books From Book Store Are: "+s1[0]+", "+" .");
            Console.WriteLine("Student Name: "+s2.Name+" Student RollNo: "+s2.RollNo+" Address: "+s2.GetAddress()+" Student Taken Books From Book Store Are: "+s2[0]+", "+s2[1]+" ,"+s2[2]+" .");
            Console.WriteLine("Student Name: "+s3.Name+" Student RollNo: "+s3.RollNo+" Address: "+s3.GetAddress()+" Student Taken Books From Book Store Are: "+s3[0]+", "+s3[1]+" .");
            Console.WriteLine("Student Name: "+s4.Name+" Student RollNo: "+s4.RollNo+" Address: "+s4.GetAddress()+" Student Taken Books From Book Store Are: "+s4[0]+", "+s4[1]+" .");
            Console.WriteLine(s1.PersonalId);
            Console.WriteLine(s2.PersonalId);
            Console.WriteLine(s3.PersonalId);
            Console.WriteLine(s4.PersonalId);
        }
    }
}