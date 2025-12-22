// Binary to Decimal: Convert a binary number string to decimal without using built-in library functions.
namespace Practice
{
    class BinaryToDecimal
    {
        public int Conversion(string value)
        {
            int result = 0;
            int power = 1;

            for(int i = value.Length-1; i>=0; i--)
            {
                if(value[i] == '1')
                {
                    result = result + power;
                }
                power = power * 2;
            }
            return result;
        }
    }
}