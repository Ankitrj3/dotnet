namespace Likhi{
public partial class Students
{
    public string? StudentName { get; private set; }
    public int StudentId { get; private set; }

    public void SetName(string name)
    {
        StudentName = name;
    }
    public void SetId(int id)
    {
        StudentId = id;
    }

    public void StudentInfo()
    {
        Console.WriteLine($"Student name {StudentName} and his id is {StudentId}");
    }
    
}
}