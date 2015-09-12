/*
        Find LCM(1234, 3456)
 */

using System;
using System.Linq;
using System.Collections.Generic;

class LeastCommonMultiple
{
    static void Main()
    {
        List<int> numbers = new List<int>{1234, 3456};

        List<int> firstDivisors = DivisiorFinder(numbers[0]);
        List<int> secondDivisors = DivisiorFinder(numbers[1]);
        firstDivisors.Reverse();
        secondDivisors.Reverse();

        bool stop = true;
        int GCD = 0;
        while (stop)
        {
            for (int i = 0; i < firstDivisors.Count; i++)
            {
                for (int j = 0; j < secondDivisors.Count; j++)
                {
                    if (firstDivisors[i] == secondDivisors[j])
                    {
                        GCD = firstDivisors[i];
                        firstDivisors.RemoveAt(i);
                        secondDivisors.RemoveAt(j);
                        stop = false;
                        break;
                    }
                }
                if (i == firstDivisors.Count - 1)
                {
                    stop = false;
                }
            }
        }

        long firstDivSum = firstDivisors.Aggregate((a, b) => b * a);
        long secDivSum = secondDivisors.Aggregate((a, b) => b * a);

        long LCM = GCD * firstDivSum * secDivSum;

        Console.WriteLine("GCD [1234,3456] = {0}", GCD);
        Console.WriteLine("LCM [1234,3456] = {0}", LCM);

        Console.WriteLine("\r\nPress Enter to EXIT.");
        Console.ReadLine();
    }

    static List<int> DivisiorFinder(int number)
    {
        List<int> divisorList = new List<int>();
        int current = number;

        int divisor = 2;
        while (current > 1 && divisor <= current)
        {
            if (current % divisor == 0)
            {
                current /= divisor;
                divisorList.Add(divisor);
                divisor = 2;
            }
            else
            {
                divisor++;
            }
        }
        return divisorList;
    }
}
