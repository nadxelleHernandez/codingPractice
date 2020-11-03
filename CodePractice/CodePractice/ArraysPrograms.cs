using System;

namespace CodePractice
{
    class ArraysPrograms
    {
        /// <summary>
        /// You are given a list of n-1 integers and these integers are in the range of 1 to n. 
        /// There are no duplicates in list.One of the integers is missing in the list. Write an efficient code 
        /// to find the missing integer.
        /// </summary>
        /// <param name="array">array of n integers </param>
        /// <returns>mising integer or 0 if array is null</returns>
        static public uint MissingInteger(uint []array)
        {
            if (array == null) return 0;

            uint n = (uint) array.Length + 1;
            uint sumExpected;
            uint sumReal = 0;

            sumExpected = (n * (n + 1)) / 2;
            
            for(int i = 0; i < array.Length; i++)
            {
                sumReal += array[i];
            }

            return sumExpected-sumReal;
        }
    }
}