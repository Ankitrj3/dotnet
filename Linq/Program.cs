// Linq Is Language Integrated Query
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Linq
{
    public class Program
    {
        public static void Main()
        {
            string[] names = { "A", "B", "C" };
            var findName = from nam in names
                           where nam == "B"
                           select nam;
            if (findName != null)
            {
                Console.WriteLine("Found Value in names");
            }

            var descendingOrder = from n in names
                                  orderby n descending
                                  select n;
            foreach (var i in descendingOrder)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            List<int> list = new List<int> { 12, 35, 6, 31, 24, 53, 3467 };
            var result = list.Where(n => n > 25);
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
            // WHERE + SELECT together
            var doubleVal = list
                            .Where(n => n > 25)
                            .Select(n => n * 2);
            foreach (var i in doubleVal)
            {
                Console.WriteLine("Doubled Value " + i);
            }

            var evenNumber = list.Where(n => n % 2 == 0);
            foreach (var i in evenNumber)
            {
                Console.WriteLine($"Even Values {i}");
            }

            // Palindrome
            List<string> val = new List<string> { "mom", "Ank", "robin", "BOb" };
            var palindromeCheck = from v in val
                                  orderby v ascending
                                  select IsPalindrome(v);

            foreach (var i in palindromeCheck)
            {
                Console.WriteLine(i);
            }

            // LinqExample();
            // LinqExample1();

            // Linq with Object
            List<Student> students = new List<Student>
            {
                new Student{Id=1, Name="Ankit", Marks=90, Dept="CSE"},
                new Student{Id=2, Name="Ravi", Marks=60, Dept="HR"},
                new Student{Id=3, Name="Neha", Marks=85, Dept="IT"},
                new Student{Id=4, Name="Saira", Marks=92, Dept="CSE"},
                new Student{Id=5, Name="Vikram", Marks=45, Dept="IT"},
                new Student{Id=6, Name="Priya", Marks=77, Dept="HR"},
                new Student{Id=7, Name="Rahul", Marks=88, Dept="CSE"},
                new Student{Id=8, Name="Sneha", Marks=33, Dept="IT"},
                new Student{Id=9, Name="Arjun", Marks=95, Dept="CSE"},
                new Student{Id=10, Name="Megha", Marks=55, Dept="HR"},
                new Student{Id=11, Name="Kabir", Marks=81, Dept="IT"},
                new Student{Id=12, Name="Ankit", Marks=34, Dept="CSE"}
            };
            var toppers = students.Where(s => s.Marks > 80);

            foreach (var s in toppers)
                Console.WriteLine(s.Name);

            students.Where(s => s.Marks > 80)
                    .Select(s => s.Name)
                    .ToList()
                    .ForEach(Console.WriteLine);

            var secondHighest = students
                                .OrderByDescending(s => s.Marks)
                                .Skip(1)
                                .First();
            Console.WriteLine(secondHighest.Name + " and marks " + secondHighest.Marks);

            //Using LINQ, display
            // Only even numbers
            // Only odd numbers

            var onlyEven = students
                           .Where(s => s.Marks % 2 == 0);

            foreach (var even in onlyEven)
            {
                Console.WriteLine(even.Name + " " + even.Marks);
            }

            var onlyOdd = students
                          .Where(s => s.Marks % 2 != 0);

            foreach (var odd in onlyOdd)
            {
                Console.WriteLine(odd.Name + " " + odd.Marks);
            }
            // From a list of integers:
            // Find sum
            // Find average
            // Find maximum
            // Find minimum
            var TotalMarks = students.Sum(s => s.Marks);
            Console.WriteLine("Total Marks " + TotalMarks);

            var averageMarks = students.Average(s => s.Marks);
            Console.WriteLine(averageMarks);

            var MaxMarks = students.Max(s => s.Marks);
            Console.WriteLine(MaxMarks);

            var MinMarks = students.Min(s => s.Marks);
            Console.WriteLine(MinMarks);

            // Display only student names
            var onlyStudentName = students.Select(s => s.Name);
            foreach (var stu in onlyStudentName)
            {
                Console.Write(stu + " ");
            }
            Console.WriteLine();

            // Display students who scored more than 60 marks
            var onlyStudentMarksIsMoreThen60 = students.Where(s => s.Marks >= 60);
            foreach (var stu in onlyStudentMarksIsMoreThen60)
            {
                Console.WriteLine(stu.Name + " " + stu.Marks);
            }

            // Sort students by:
            // Marks (descending)
            // Name (ascending)
            var sortOnMarks = students
                              .OrderByDescending(s => s.Marks)
                              .ThenBy(s => s.Name);
            Console.WriteLine("Sort on name and Marks");
            foreach (var sn in sortOnMarks)
            {
                Console.WriteLine($"{sn.Name} and {sn.Marks}");
            }

            // Find the top 3 highest scoring students
            var TakeTopThreeStudent = students
                                      .OrderByDescending(s => s.Marks)
                                      .Take(3);
            Console.WriteLine("Top 3 students");
            foreach (var i in TakeTopThreeStudent)
            {
                Console.WriteLine($"{i.Name} + {i.Dept} + {i.Marks}");
            }

            // Skip first 2 students and display the rest
            var Skip2Student = students
                               .OrderByDescending(s => s.Marks)
                               .Skip(2);
            Console.WriteLine("skip 2 students");
            foreach (var i in Skip2Student)
            {
                Console.WriteLine($"{i.Name} {i.Marks}");
            }
            // Remove duplicate names
            var RemoveDuplicateName = students
                                      .Select(s => s.Name)
                                      .Distinct();
            Console.WriteLine("Remove Duplicate Name");
            foreach (var i in RemoveDuplicateName)
            {
                Console.WriteLine($"{i}");
            }
            // Find Total Marks per Department
            var TotalMarksAsDepart = students
                                     .GroupBy(s => s.Dept)
                                     .Select(lik => new
                                     {
                                         Department = lik.Key,
                                         Marks = lik.Sum(s => s.Marks)
                                     });
            foreach (var i in TotalMarksAsDepart)
            {
                Console.WriteLine("Department = " + i.Department + " Total Marks = " + i.Marks);
            }
            // Count Number of Students per Department
            var CountPersonInEachDept = students
                                        .GroupBy(s => s.Dept)
                                        .Select(g => new
                                        {
                                            Department = g.Key,
                                            Count = g.Count()
                                        });
            Console.WriteLine("Count Person as Per Department");
            foreach (var i in CountPersonInEachDept)
            {
                Console.WriteLine("Department = " + i.Department + " Total Marks = " + i.Count);
            }
            // Find the First Student who scored > 70
            var firstStudent = students.FirstOrDefault(s => s.Marks > 70);
            Console.WriteLine("First Name Who score more then 70 " + firstStudent.Name + " " + firstStudent.Marks);

            // Check whether Any Student Failed (Marks < 40)
            bool AnyFailed = students.Any(s => s.Marks < 40);
            Console.WriteLine(AnyFailed);
            // Check whether All Students Passed
            var StudentPass = students.All(s => s.Marks >= 40);
            Console.WriteLine(StudentPass);

            // Find Common Elements
            List<int> list1 = new() { 1, 2, 3, 4 };
            List<int> list2 = new() { 3, 4, 5, 6 };
            var common = list1.Intersect(list2);
            foreach (var n in common)
                Console.WriteLine(n);

            // Find All Unique Elements
            Console.WriteLine("Unique Elements");
            var Unique = list1.Union(list2);
            foreach (var n in Unique)
                Console.WriteLine(n);

            // Anonymous Type → Name & Result (Pass / Fail)
            var result1 = students.Select(s => new
            {
                s.Name,
                Result = s.Marks >= 40 ? "Pass" : "Fail"
            });

            foreach (var r in result1)
            {
                Console.WriteLine($"{r.Name} - {r.Result}");
            }
            // Find Second Highest Marks

            int secondHighest1 = students
                                .OrderByDescending(s => s.Marks)
                                .Select(s => s.Marks)
                                .Distinct()
                                .Skip(1)
                                .First();

            Console.WriteLine(secondHighest1);


        }
        private static void LinqExample()
        {
            var processCollection = from p in System.Diagnostics.Process.GetProcesses()
                                    select new MyProcess() { Name = p.ProcessName, Id = p.Id };

            foreach (var process in processCollection)
            {
                Console.WriteLine($"Process: {process.Name} Id = {process.Id}");
            }
        }
        // Anonymous Type 
        private static void LinqExample1()
        {
            var processCollection = from p in System.Diagnostics.Process.GetProcesses()
                                    select new { Name = p.ProcessName, Id = p.Id };

            foreach (var process in processCollection)
            {
                Console.WriteLine($"Process: {process.Name} Id = {process.Id}");
            }
        }
        public static string IsPalindrome(string name)
        {
            string reversed = new string(name.Reverse().ToArray());
            if (string.Equals(reversed, name, StringComparison.OrdinalIgnoreCase))
            {
                return "Its Palindrome " + name;
            }
            else
            {
                return "Its not Palindrome " + name;
            }
        }
    }
}