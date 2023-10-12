// See https://aka.ms/new-console-template for more information
using System;

namespace YandexCrowd // 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start");
            
            int maxPrimeNumber = 200;
            PrimeNumbers pr = new PrimeNumbers();
            List<int> numbers = pr.FindPrimeNumbers(maxPrimeNumber);
            numbers.ForEach(delegate(int i)
            {
                Console.WriteLine(i);
            });
            Console.WriteLine("Searching prime numbers for " + maxPrimeNumber 
                + " took " + pr.GetIterations() + " iterations");

            int capacity = 20;
            int maxNumber = 100;
            ArrayOfInt data = new ArrayOfInt(100, 20);
            Console.WriteLine("Created array of " + capacity +" numbers from 1 to " + maxNumber);
            int sum = data.GetDataSum();
            int power = new PowerOfTwo().GetBiggerPowerOfTwo(sum);
            Console.WriteLine("Closest power of 2 for " + sum +
                " is " + power + " (" + Math.Pow(2,power) + ")");
                
            
        }


    }
}
