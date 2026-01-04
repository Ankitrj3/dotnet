// Question 9: Interface vs Abstract Class – Reporting Module
// Design a reporting system for PDF, Excel, and CSV formats and justify interface or abstract class usage.
public interface IOReportingSystem
{
    public void GenerateReport();
}
public class ReportingSystem : IOReportingSystem
{
    public void GenerateReport()
    {
        Console.WriteLine("PDF Report Generated");
    }
}
public sealed class CSV : IOReportingSystem
{
    public void GenerateReport()
    {
        Console.WriteLine("CSV Report Generated");
    }
}
public sealed class Excel : IOReportingSystem
{
    public void GenerateReport()
    {
        Console.WriteLine("Excel Report Generated");
    }
}