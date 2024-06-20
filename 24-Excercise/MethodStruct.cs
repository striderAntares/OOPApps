using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _24_Excercise
{
    internal static class MethodStruct
    {
        public static bool IDNoChecker(this string number)
        {
            if (number.Length != 11)
                return false;
            if (number[0] == '0')
                return false;
            int sum1 = 0, sum2 = 0;
            for (int i = 0; i < 9; i++)
            {
                int digit = number[i] - '0';
                if (i % 2 == 0)
                    sum1 += digit;
                else
                    sum2 += digit;
            }
            int tenthDigit = (sum1 * 7 - sum2) % 10;
            if (tenthDigit != (number[9] - '0'))
                return false;
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += number[i] - '0';
            }
            int eleventhDigit = sum % 10;
            if (eleventhDigit != (number[10] - '0'))
                return false;

            return true;
        }
        public static bool IsValidEmail(this string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
        public static string ClearString(this string param)
        {
            param = param.ToLower().Replace("ş", "s").Replace("ğ", "g").Replace("ç", "c").Replace("ü", "u").Replace("ı", "i").Replace("ö", "o").Replace("â", "a");

            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(param);
        }

        public static bool MobileNumberChecker(this string input)
        {

            if (input.Length != 10)
                return false;


            if (input[0] != '5' || input[0] == '0')
                return false;

            return true;
        }
    }
}
