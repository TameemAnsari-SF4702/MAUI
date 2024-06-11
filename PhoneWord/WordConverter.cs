using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneWord
{
    public static class WordConverter
    {
        
        public static string Translator(string phoneWord)
        {
            string result = "";
            foreach (char letter in phoneWord)
            {
                if (letter == 'A' || letter == 'B' || letter == 'C')
                {
                    result += "2";
                }
                else if (letter == 'D' || letter == 'E' || letter == 'F')
                {
                    result += "3";
                }
                else if (letter == 'G' || letter == 'H' || letter == 'I')
                {
                    result += "4";
                }
                else if (letter == 'J' || letter == 'K' || letter == 'L')
                {
                    result += "5";
                }
                else if (letter == 'M' || letter == 'N' || letter == 'O')
                {
                    result += "6";
                }
                else if (letter == 'P' || letter == 'Q' || letter == 'R' || letter == 'S')
                {
                    result += "7";
                }
                else if (letter == 'T' || letter == 'U' || letter == 'V')
                {
                    result += "8";
                }
                else if (letter == 'W' || letter == 'X' || letter == 'Y'|| letter == 'Z')
                {
                    result += "9";
                }
                else {
                    result += letter;
                }
            }
            return result;
        }
    }
}
