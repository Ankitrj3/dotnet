using LocalGenericCollection;
namespace LocalGenericCollection
{
    public class Student
    {
        public int StudentId{get; set;}
    }
    public class UGStudent : Student
    {
        public double HighSchoolMarks{get; set;}
    }
    public class PGStudent : Student
    {
        public double UGMarks{get; set;}
    }
}
namespace GenericCollection
{
    public class MyGenericClass<T>
    {
        public string GetTypeOfStudent(T? t)
        {
            return t.GetType().ToString();
        }

        public string GetTypeMessage(T? t)
        {
            if(t is PGStudent)
            {
                return "PG Student";
            }
            if (t is UGStudent)
            {
                return "UG Student";
            }
            return "Normal Student";
        }
    }
}