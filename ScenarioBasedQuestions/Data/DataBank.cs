using System.Collections.Generic;

namespace Student
{
    class DataBank
    {
        private static List<Student> students = new List<Student>();
        private static List<StudentSession> studentSessions = new List<StudentSession>();
        static DataBank()
        {
            students.Add(new Student(){Id = 1, Name = "Ankit"});
            students.Add(new Student(){Id = 2, Name = "Ankit1"});
            students.Add(new Student(){Id = 3, Name = "Ankit2"});
            studentSessions.Add(new StudentSession(){SessionId=22, Name="shashi"});
            studentSessions.Add(new StudentSession(){SessionId=222, Name="shashi2"});
        }
        
        public static List<Student> GetStudents()
        {
            return students;
        }
        public static List<StudentSession> GetStudentSessions()
        {
            return studentSessions;
        }
    }
}