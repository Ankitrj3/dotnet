public class YogaMeditation
{
    public int MemberId { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }
    public double Height { get; set; }
    public string? Goal { get; set; }
    public double BMI { get; set; }

    public YogaMeditation() { }

    public static List<YogaMeditation> yogaMedi = new List<YogaMeditation>();
    public void AddYogaMeditation(int MemberId, int Age, double Weight, double Height, string Goal)
    {
        YogaMeditation yoga = new YogaMeditation
        {
            MemberId = MemberId,
            Age = Age,
            Weight = Weight,
            Height = Height,
            Goal = Goal,
            BMI = 0
        };
        yogaMedi.Add(yoga);
    }
    public double CalculateBMI(int memberId)
    {
        foreach (var y in yogaMedi)
        {
            if (y.MemberId == memberId)
            {
                double heightInMeters = y.Height * 0.3048;
                double bmi = y.Weight / (heightInMeters * heightInMeters);

                bmi = Math.Floor(bmi * 100) / 100;
                y.BMI = bmi;

                return bmi;
            }
        }
        return 0;
    }
    public int CalculateFee(int memberId)
    {
        foreach (var m in yogaMedi)
        {
            if (m.MemberId == memberId)
            {
                if (m.BMI == 0)
                {
                    CalculateBMI(memberId);
                }
                if (m.Goal == "Weight Gain")
                {
                    return 2500;
                }
                if (m.Goal == "Weight Loss")
                {
                    if (m.BMI >= 25 && m.BMI < 30)
                    {
                        return 2000;
                    }
                    else if (m.BMI >= 30 && m.BMI < 35)
                    {
                        return 2500;
                    }
                    else if (m.BMI >= 35)
                    {
                        return 3000;
                    }
                }
            }
        }
        return 0;
    }
}