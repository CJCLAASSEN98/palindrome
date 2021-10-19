using System;

namespace PalindromeProblem
{
    public class Utils
    {
        public static string RevNum(string str)
        {

            string  revString = "";
            for(int i=str.Length-1; i>=0; i--)
            {
                revString = revString + str[i];
            }
            return revString;
        }
    }
}
