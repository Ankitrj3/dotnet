namespace GPA
{
    public class CalculateGPA
    {
        public static List<int> GPAMarks = new List<int>();

        public void AddMarks(int num)
        {
            GPAMarks.Add(num);
        }
        public double GetGPAScored()
        {
            if (GPAMarks.Count() == 0)
            {
                return -1;
            }
            var sum = 0;
            foreach(var gpa in GPAMarks)
            {
                sum += (gpa * 3);
            }
            double gg = sum/(GPAMarks.Count * 3);
            return gg;
        }
        public char GetGradeScored(double gpa)
        {
            if(gpa < 5 || gpa > 10)
            {
                return '\0';
            }
            if(gpa == 10)
            {
                return 'S';
            }else if(gpa >= 9 && gpa < 10)
            {
                return 'A';
            }else if(gpa >= 8 && gpa < 9)
            {
                return 'B';
            }else if(gpa >= 7 && gpa < 8)
            {
                return 'C';
            }else if(gpa >= 6 && gpa < 7)
            {
                return 'D';
            }else if(gpa >= 5 && gpa < 6)
            {
                return 'E';
            }
            return '/';
        }
    }
}