using System;
using System.Collections.Generic;

namespace randomSquared
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> randomNumbers = new List<int>();
            Random randomNumber = new Random();
            for (int i = 0; i < 20; i++){
              int theNumber = randomNumber.Next(51);
              randomNumbers.Add(theNumber);
            }

            List<double> squaredNumbers = new List<double>();

            foreach (int num in randomNumbers)
            {
              squaredNumbers.Add((num * num));
            }

            List<double> onlyEvens = new List<double>();

            foreach (double num in squaredNumbers)
            {
              if ((num % 2 == 0)) {
                onlyEvens.Add(num);
              }
            }
            Console.WriteLine($"All Squares: {String.Join(", ", squaredNumbers)}");
            Console.WriteLine($"Even squares: {String.Join(", ", onlyEvens)}");
        }
    }
}
