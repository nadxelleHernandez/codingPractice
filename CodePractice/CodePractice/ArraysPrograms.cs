using System;
using System.Text;

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

        /// <summary>
        /// Given an unsorted array of nonnegative integers, find a continuous subarray which adds to a given number.
        /// </summary>
        /// <param name="array">The positive integers array</param>
        /// <param name="sum">the number the subarray must add to</param>
        /// <returns>An array with the indexes where the subarray is located, null if nothing was found</returns>
        static public uint [] SubArraySum(uint[] array, uint sum)
        {
            uint[] indexes = null;

            if (array == null) return null;

            indexes = new uint[2];
            if(array.Length==1)
            {
                if (array[0] == sum)
                {
                   
                    return indexes;
                } 
                else
                {
                    return null;
                }
            }

            uint subSum = array[0];
            bool nonSumFound = true;
            bool addedNumber = false;
            for (uint i = 1; i < array.Length; i++)
            {
                if (subSum < sum) //hay que seguir sumando
                {
                    subSum += array[i];
                    indexes[1]++;
                    addedNumber = true;
                }
                else if (subSum > sum) // me pase de la suma
                {
                    indexes[0] = indexes[1];  //reinicio los indices del subarreglo
                    indexes[1] = indexes[1];
                    if (addedNumber)
                    {
                        i--;
                        addedNumber=false; //reinicio la bandera de suma
                    }
                    subSum = array[i];
                }
                else //son iguales!! la encontre
                {
                    nonSumFound = false;
                    break;
                }

            }

            if (nonSumFound) return null;

            return indexes;
        }

        //Comparar dos cadenas. La primera tiene numeros y letras. La segunda es un patron donde # representa 1 digito y *una letra o numero pero no espacios
    }
}