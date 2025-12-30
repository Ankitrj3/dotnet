using System.Text.RegularExpressions;
using System;
using RegularExpression;

namespace RegularExpression
{
    public class TimeOut
    {
        public void APICall()
        {
            string input = "Error: TIMEOUT while calling API";
            string pattern = @"timeout";

            var rx = new Regex
            (
                pattern,
                RegexOptions.IgnoreCase,
                TimeSpan.FromMilliseconds(150)
            );
            Console.WriteLine(rx.IsMatch(input) ? "Found" : "Not Found");
        }
    }
}
