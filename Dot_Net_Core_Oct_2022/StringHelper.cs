using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Core_Oct_2022
{
    static internal class StringHelper
    {
        public static string FlipFirstLetterCase(this string input)
        {
            if (input.Length > 0)
            {
                var charArr = input.ToCharArray();
                charArr[0] = char.IsUpper(charArr[0]) ?
                                char.ToLower(charArr[0]) :
                                char.ToUpper(charArr[0]);
                return new string(charArr);
            }

            return input;
        }
    }
}
