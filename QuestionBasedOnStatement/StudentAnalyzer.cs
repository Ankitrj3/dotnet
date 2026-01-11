public class Student
{
    public int RollNo{get; set;}
    public string? Name{get; set;}
    public int Marks{get; set;}

    public Student(){}
}
public class StudentAnalyzer
{
    public Student GetTopper(IList<Student> students)
    {
        int Topper = int.MinValue;
        Student TopStudent = null;
        foreach(Student s in students)
        {
            if(s.Marks > Topper)
            {
                Topper = s.Marks;
                TopStudent = s;
            }
        }
        return TopStudent;
    }
    public IList<Student> GetPassedStudents(IList<Student> students)
    {
        IList<Student> res = new List<Student>();
        foreach(Student s in students)
        {
            if(s.Marks >= 40)
            {
                res.Add(s);
            }
        }
        return res;
    }
}