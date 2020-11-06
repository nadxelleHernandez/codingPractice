using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice
{
    class StringPrograms
    {
        /// <summary>
        /// Function that analyse the given string and determines if it is like the pattern given.
        /// </summary>
        /// <param name="myString">the given string</param>
        /// <param name="pattern">The pattern can have '#' which means that the given string can have there any number
        /// or '*' which means that it can have any letter or number but not special caracters or spaces. Each '#' or '*' 
        /// account for only one character</param>
        /// <returns>True if the given string is like the patter, false if not or if any of the parameters are null</returns>
        public static bool IsStringLikePattern(string myString, string pattern)
        {
            if (myString == null || pattern == null) return false;

            if (myString.Length != pattern.Length) return false; // they aren't the same length

            int i = 0;
            foreach(char c in pattern)
            {
                if(c==myString[i])
                {
                    i++;
                    continue;
                }
                if (c == '*')
                {
                    i++;
                    continue;
                }
                if (c == '#')
                {
                    if (Char.IsDigit(myString[i]))
                    {
                        i++;
                        continue;
                    }
                    return false;
                }
                return false;
            }

            return true;
        }
    }
}
