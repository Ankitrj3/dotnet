namespace GenericValidator
{
    public delegate bool Validator<T>(T data);

    public class ValidatorService
    {
        public void ValidatorCheck<T>(T data, Validator<T> validator)
        {
            if (validator(data))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Not Valid");
            }
        }
    }
    public class Program
    {
        public static void Main()
        {
            Validator<int> intCheck = ValidNumber;
            ValidatorService vs = new ValidatorService();
            vs.ValidatorCheck(12,intCheck);
            vs.ValidatorCheck(-34,intCheck);
            Validator<string> stringCheck = ValidString;
            vs.ValidatorCheck("Ankit",stringCheck);
            vs.ValidatorCheck("AnkitRanjan",stringCheck);
        }
        public static bool ValidNumber(int num)
        {
            if(num > 0)
            {
                return true;
            }
            return false;
        }
        public static bool ValidString(string str)
        {
            if(str.Length > 5)
            {
                return true;
            }
            return false;
        }
    }
}