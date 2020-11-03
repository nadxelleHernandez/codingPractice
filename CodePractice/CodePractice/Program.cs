using System;

namespace CodePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayProblems!");

            uint[] a = { 1, 2, 3, 4, 5, 6, 8, 9, 10 };

            Console.WriteLine("Missing integer is: {0}", ArraysPrograms.MissingInteger(a));
        }
    }
}
