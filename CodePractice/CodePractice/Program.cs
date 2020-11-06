using System;
using System.Runtime.InteropServices.ComTypes;

namespace CodePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayProblems!");

            uint[] a = { 1, 2, 3, 4, 5, 6, 8, 9, 10 };

            Console.WriteLine("Missing integer is: {0}", ArraysPrograms.MissingInteger(a));

            Console.WriteLine("Encontrando las suma");

            uint[] b = { 4,5,10,8,1,7};
            uint sum = 11;
            uint[] indexes = ArraysPrograms.SubArraySum(b, sum);
            if (indexes == null)
                Console.WriteLine("no hay subarreglo que sume {0}", sum);
            else
                Console.WriteLine("el subarray que suma {2} esta entre los {0}  y  {1} indices", indexes[0], indexes[1], sum);

            string myString = "aea7672q";
            string pattern = "a***###q";
            Console.WriteLine("Comparando cadenas: {0} y {1}",myString, pattern );
            Console.WriteLine(StringPrograms.IsStringLikePattern(myString, pattern));
           
        }
    }
}
