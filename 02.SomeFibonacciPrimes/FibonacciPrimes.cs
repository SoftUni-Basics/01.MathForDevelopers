/*
    Check if the 24th, 101st and 251st prime numbers are part of the base Fibonacci number set. 
    What is their position?
 */
using System;
using System.Collections.Generic;
using System.Linq;

class FibonacciPrimes
{
    static void Main()
    {
        int[] primeNumbers = { 24, 101, 251 };
        int[] primeValues = new int[primeNumbers.Length];

        int primeIndex = 0;
        int primeCount = 1;
        int numberToCheck = 2;

        while (primeValues.Last() == 0)
        {
            for (int i = 2; i <= numberToCheck; i++)
            {
                if (numberToCheck % i == 0 && numberToCheck != i)
                {
                    break;
                }

                else if (numberToCheck == i)
                {
                    if (primeNumbers[primeIndex] == primeCount)
                    {
                        primeValues[primeIndex] = numberToCheck;
                        primeIndex++;
                    }
                    primeCount++;
                }
            }
            numberToCheck++;
        }

        List<int> fibValues = new List<int>();
        int fibonnacci = 0;
        int tempFib = 1;
        
        while (fibonnacci <= primeValues.Last())
        {
            fibValues.Add(fibonnacci);

            int sum = fibonnacci + tempFib;
            fibonnacci = tempFib;
            tempFib = sum;
        }

        for (int primIndex = 0; primIndex < primeValues.Length; primIndex++)
        {
            for (int fibIndex = 0; fibIndex < fibValues.Count; fibIndex++)
            {
                if (fibValues[fibIndex] > primeValues[primIndex])
                {
                    Console.WriteLine("Prime Nomber({0,3}) = {1,4};                  is NOT part of the Fibonacci set.", 
                        primeNumbers[primIndex], primeValues[primIndex]);
                    break;
                }
                else if (fibValues[fibIndex] == primeValues[primIndex])
                {
                    Console.WriteLine("Prime Nomber({0,3}) = {1,4}; Position{2,3};     is part of the Fibonacci set.",
                        primeNumbers[primIndex], primeValues[primIndex], fibIndex);
                    break;
                }
            }
        }

        Console.WriteLine("\r\nPress Enter to EXIT.");
        Console.ReadLine();
    }
}
