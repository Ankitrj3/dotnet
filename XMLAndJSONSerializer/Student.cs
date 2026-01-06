using System.Security.Cryptography;

namespace XMLSerializer
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int[]? Marks{get; set;}
        private int age{get; set;}
        public int Age
        {
            get {return age;}
            set {age = value;}
        }
        public List<string?> Subject = new List<string?>();

    }
}