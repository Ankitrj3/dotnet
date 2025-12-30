using System.Dynamic;
using Microsoft.VisualBasic;

namespace shashi
{
    static class Students
    {
        public static int StudentId{get; private set;}
        public static string? StudentName{get; private set;}
        
        static Students()
        {
            StudentName = "";
            StudentId = 0;
        }
        public static void SetInfo(string? name, int Id)
        {
            StudentName = name;
            StudentId = Id;
        }
        public static void Information(){
            Console.WriteLine($"your name is {StudentName} and your id is {StudentId}");
        }
    }
}