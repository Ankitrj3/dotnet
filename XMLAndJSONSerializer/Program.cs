using System.IO;
using System.Reflection.PortableExecutable;
using System.Xml.Serialization;
using System.Text.Json;
using DeligatesFun;

namespace XMLSerializer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student() { Id = 1, Name = "Ankit", Age=22};
            s1.Marks = new int[]{12,34,566,78,90};
            s1.Subject.Add("English");
            s1.Subject.Add("IT");
            // Method-1
            XmlSerializer serializer = new XmlSerializer(typeof(Student));
            using StringWriter writer = new StringWriter();
            serializer.Serialize(writer, s1);
            string xml = writer.ToString();
            Console.WriteLine(xml);


            // Method-2
            XmlSerializer x = new XmlSerializer(s1.GetType());
            // x.Serialize(Console.Out, s1);  // this is directly printing the xml in console without converting in string
            using StringWriter writer1 = new StringWriter();
            x.Serialize(writer1,s1);
            string serial = writer1.ToString();
            Console.WriteLine(serial);

            // JSON Serializer
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json = JsonSerializer.Serialize(s1, options);
            Console.WriteLine(json);


            Deligates dl = new Deligates();
            dl.DelegateEx1();
        }
    }
}