using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "This is a tab.\t This is a new line \n";
            string str1 = @"This ain't a tab. \t This ain't a new line \n";
            string str2 = "This is an omega \u03A9";
            string str3 = @"This ain't an omega \u03A9";

            System.Console.WriteLine(str);
            System.Console.WriteLine(str1);
            System.Console.WriteLine(str2);
            System.Console.WriteLine(str3);
        }
    }
}
