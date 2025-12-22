/// <summary>
/// BinaryToDecimal - Converts binary number strings to decimal integers
/// This class implements binary to decimal conversion without using built-in library functions
/// Uses positional notation: each binary digit represents a power of 2
/// </summary>
// Binary to Decimal: Convert a binary number string to decimal without using built-in library functions.
namespace Practice
{
    class BinaryToDecimal
    {
        /// <summary>
        /// Converts a binary string to its decimal equivalent
        /// Algorithm: Iterate from right to left, multiply each bit by corresponding power of 2
        /// </summary>
        /// <param name="value">Binary string (e.g., "1011")</param>
        /// <returns>Decimal equivalent of the binary number</returns>
        public int Conversion(string value)
        {
            int result = 0;  // Accumulator for decimal result
            int power = 1;   // Current power of 2 (starts with 2^0 = 1)

            // Process binary string from right to left (least significant bit first)
            for(int i = value.Length-1; i>=0; i--)
            {
                // If current bit is '1', add the corresponding power of 2
                if(value[i] == '1')
                {
                    result = result + power;  // Add current power of 2 to result
                }
                power = power * 2;  // Move to next power of 2 (2^1, 2^2, 2^3, etc.)
            }
            return result;
        }
    }
}