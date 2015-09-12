/*
    Find the 24th, 101st and 251st prime number.
*/

using System;
using System.Linq;

class SomePrimes
{
    static void Main()
    {
        int[] primesToFind = { 24, 101, 251 };
        int[] primeValues = new int[primesToFind.Length];

        int index = 0;
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
                    if (primesToFind[index] == primeCount)
                    {
                        primeValues[index] = numberToCheck;
                        index++;
                    }
                    primeCount++;
                }
            }
            numberToCheck++;
        }

        for (int i = 0; i < primeValues.Length; i++)
        {
            Console.WriteLine("Prime({0,3}) = {1}", primesToFind[i], primeValues[i]);
        }
        Console.WriteLine("\r\nPress Enter to EXIT.");
        Console.ReadLine();
    }
}


