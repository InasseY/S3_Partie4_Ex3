using System;
using System.Collections.Generic;
using System.Linq;

namespace S3_Partie4_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            List<int> number = new List<int>() { 10, 12, 19, 25, 28};

            result = number.Sum();

            Console.WriteLine($"le résultat de ton addition est de {result}");

            //
            string usedNumber = String.Join(" + ", number);
            Console.WriteLine(usedNumber);
        }
    }
}
