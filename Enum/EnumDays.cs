using System;

namespace Enum1
{
    public enum Days
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }

    public class EnumDays
    {
        public void PrintDays()
        {
            foreach (Days day in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine($"{day} = {(int)day}");
            }

            Days d = (Days)1;
            Console.WriteLine("Assigned day: " + d);
        }
    }
}
