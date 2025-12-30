using System.Text;

namespace ExtensionMethod
{
    public static class Palindrome
    {
        public static bool CheckPalindromeRes(this string str)
        {
            // string strValue = str.ToLower();

            // string reverse = new string(strValue.Reverse().ToArray());

            // if (strValue.Equals(reverse))
            // {
            //     return ("It's Palindrome");
            // }
            // else
            // {
            //     return ("It's Not Palindrome Kindly enter new Value");
            // }

            int left = 0;
            int right = str.Length-1;
            while(left < right)
            {
                if(str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}