using System;
using System.Collections.Generic;

namespace S3_Partie4_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            List<int> number = new List<int>() { 10, 12, 19, 25, 28};

            for (int i = 0; i < number.Count; i++)
            {
                result += number[i];
                
            }

            Console.WriteLine($"le résultat de ton addition est de {result}");
            

        }
    }
}
