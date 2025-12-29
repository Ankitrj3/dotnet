namespace Likhi{
public partial class Students
{
    public string? CoreCSE { get; private set; }

    public void SetCoreCSE(string Core)
    {
        CoreCSE = Core;
    }
    public void InformationWithSubjects()
    {
        StudentInfo();
        Console.WriteLine($"this main stream is : {CoreCSE}");
    }
}
}