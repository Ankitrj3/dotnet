namespace Likhi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Students s1 = new Students();
            s1.SetName("Ankit");
            s1.SetId(1234545);
            s1.SetCoreCSE("CSE");
            s1.InformationWithSubjects();
        }
    }
}
