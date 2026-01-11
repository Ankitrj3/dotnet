using System;

namespace CustomException
{
    public class AppCustomException1 : Exception
    {
        public override string Message => HandleBase(base.Message);
        private string HandleBase(string sysMessage)
        {
            Console.WriteLine(sysMessage);
            return "Internal Exception Occured. Please contact to admin";
        }
    }
}