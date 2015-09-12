/*
        You are given three right angled triangles. Find the length of their hypotenuses.
        Catheti: 3 and 4
        Catheti:  10 and 12
        Catheti 100 and 250
*/

using System;

class CalculateHypotenuse
{
    static void Main()
    {
        int[] a = { 3, 10, 100 };
        int[] b = { 4, 12, 250 };

        for (int i = 0; i < a.Length; i++)
        {
            double hypotenuse = Math.Sqrt(Math.Pow(a[i], 2) + Math.Pow(b[i], 2));
            Console.WriteLine("Hypotenuse with Catheti(A={0}, B={1}):\r\nHypotenuse= {2}\r\n",
                a[i], b[i], hypotenuse);
        }

        Console.WriteLine("\r\nPress Enter to EXIT.");
        Console.ReadLine();
    }
}
