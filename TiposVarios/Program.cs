using System;
using System.Text;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            char heart = '\u2665';
            char arrows = '\u21C4';

            int num1 = 12;
            float num2 = 6.8f;
            bool depression = 5 > 3;
            ulong numBig = 68000000000;
            double numSmall = 0.68549323;
            decimal num3 = 6.5M;

            Console.WriteLine("{0} {1} | {2}" , num1 , num2 , depression);
            System.Console.WriteLine($"{numBig} {numSmall} | {num3}");
            System.Console.WriteLine($"Heart = {heart} Arrows = {arrows}");
        }
    }
}
