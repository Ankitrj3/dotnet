using System;
using System.Collections.Generic;

namespace Student{
class Program
{
    public static void Main(string [] args)
    {
        var listOfStu = DataBank.GetStudents();
        Console.WriteLine("Students in the system:");
        foreach(var student in listOfStu)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
        }

        var listOfStuSession = DataBank.GetStudentSessions();
        Console.WriteLine("Student Session ....");
        foreach(var studentSession in listOfStuSession)
            {
                Console.WriteLine($"Session id {studentSession.SessionId} , Name: {studentSession.Name}");
            }
    }
}
}