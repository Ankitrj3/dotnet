using System.Diagnostics;

namespace Events
{
    public delegate void TemperatureHandler(int temperature);
    public class TemperatureCheck
    {
        public event TemperatureHandler? TempEvent;
        public void PrintTemperature(int temp)
        {
            if (TempEvent != null)
            {
                TempEvent.Invoke(temp);
            }
        }
    }
    public class MainTemp
    {
        public void TempMain(int temperature)
        {
            if (temperature > 40)
            {
                Console.WriteLine($"Warning! High Temperature: {temperature}");
            }
            else
            {
                Console.WriteLine($"Temperature is fine : {temperature}");
            }
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            TemperatureCheck tc = new TemperatureCheck();
            MainTemp mt = new MainTemp();

            tc.TempEvent += mt.TempMain;

            while (true)
            {
                Console.WriteLine("If u want to stop type quit or if u want to Continue enter Temperature");
                string? Temperature = Console.ReadLine();
                if (Temperature.Equals("quit"))
                {
                    break;
                }
                int temperature = int.Parse(Temperature);

                tc.PrintTemperature(temperature);

            }
        }
    }
}