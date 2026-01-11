using System;
using System.Linq;
namespace CustomException
{
    public class AppCustomException : Exception
    {
        public override string Message => "Internal Server Error";
    }
}