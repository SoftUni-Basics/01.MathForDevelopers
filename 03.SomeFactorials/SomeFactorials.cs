/*
    Find 100!, 171! and 250!
    Give all digits.
*/

using System;
using System.Numerics;

class SomeFactorials
{
    static void Main()
    {
        int[] factorials = { 100, 171, 250 };
        BigInteger[] allFactFullDigit = new BigInteger[3];
        int[] factZeros = new int[3];

        for (int i = 0; i < factorials.Length; i++)
        {
            allFactFullDigit[i] = GetFactDigits(factorials[i]);

            BigInteger temp = CountingFactZeros(allFactFullDigit[i]);
            factZeros[i] = (int)temp;

            Console.WriteLine("Factorial ({0}!) =\t{1}", factorials[i], allFactFullDigit[i]);
            Console.WriteLine("Factorial ({0}!) Zeros = {1}", factorials[i], factZeros[i]);
            Console.WriteLine();
        }

        Console.WriteLine("\r\nPress Enter to EXIT.");
        Console.ReadLine();
    }

    static BigInteger CountingFactZeros(BigInteger n)
    {
        int count = 0;
        BigInteger remainder = 0;
        BigInteger divider = n;
        while (remainder == 0)
        {
            remainder = divider % 10;
            divider /= 10;
            if (remainder == 0)
            {
                count++;
            }
        }
        return count;
    }

    static BigInteger GetFactDigits(int p)
    {
        BigInteger fullDigit = 1;
        for (int i = p; i > 1; i--)
        {
            fullDigit *= i;
        }
        return fullDigit;
    }
}
