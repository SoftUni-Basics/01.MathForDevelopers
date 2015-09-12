/*
        Convert 1234d       to binary   and hexadecimal     numeral systems.
        Convert 1100101b    to decimal  and hexadecimal     numeral systems.
        Convert ABChex      to decimal  and binary          numeral systems. 
*/

using System;
using System.Text;
using System.Linq;

class SystemConversions
{
    static void Main()
    {
        // Decimal to Binary and Hexadecimal
        int decValue = 1234;
        Console.WriteLine("\tDecimal ({0})", decValue);
        
        string decToBinary = Convert.ToString(decValue, 2);
        Console.WriteLine("To Binary = {0}", decToBinary);

        string decToHexa = decValue.ToString("X");
        Console.WriteLine("To Hexadecimal = {0}", decToHexa);

        Console.WriteLine();




        // Binary to Decimal and Hexadecimal
        string binValue = "1100101";
        Console.WriteLine("\tBinary ({0})", binValue);

        int binToDecimal = Convert.ToInt32(binValue, 2);
        Console.WriteLine("To Decimal = {0}",binToDecimal);

        string binToHexadecimal = BinaryStringToHexString(binValue);
        Console.WriteLine("To Hexadecimal = {0}", binToHexadecimal);

        Console.WriteLine();




        // Hexadecimal to Decimal and Binary
        string hexaValue = "ABC";
        Console.WriteLine("\tHexadecimal ({0})", hexaValue);
        
        int hexToDecimal = Convert.ToInt32(hexaValue, 16);
        Console.WriteLine("To Decimal = {0}", hexToDecimal);

        string hexToBinary = String.Join(String.Empty, hexaValue.Select(
            c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
        Console.WriteLine("To Binary = {0}", hexToBinary);

        Console.WriteLine("\r\nPress Enter to EXIT.");
        Console.ReadLine();
    }

    static string BinaryStringToHexString(string binary)
    {
        StringBuilder result = new StringBuilder(binary.Length / 8 + 1);

        // TODO: check all 1's or 0's... Will throw otherwise

        int mod4Len = binary.Length % 8;
        if (mod4Len != 0)
        {
            // pad to length multiple of 8
            binary = binary.PadLeft(((binary.Length / 8) + 1) * 8, '0');
        }

        for (int i = 0; i < binary.Length; i += 8)
        {
            string eightBits = binary.Substring(i, 8);
            result.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
        }

        return result.ToString();
    }
}
