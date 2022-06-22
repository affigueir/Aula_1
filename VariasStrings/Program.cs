using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  string str = "This is a tab.\t This is a new line \n";
            string str1 = @"This ain't a tab. \t This ain't a new line \n";
            string str2 = "This is an omega \u03A9";
            string str3 = @"This ain't an omega \u03A9"; */

            string conc = "a" + 2;
            float x = 5.99f;
            float y = 6.99f;
            string burguer = "Bob's burguers are " + x;
            string format = String.Format("Num1 is {1} and Num2 is {0}", x, y);

          /*  System.Console.WriteLine(str);
            System.Console.WriteLine(str1);
            System.Console.WriteLine(str2);
            System.Console.WriteLine(str3); */

            System.Console.WriteLine(conc);
            System.Console.WriteLine(burguer);
            System.Console.WriteLine($"Burguer 1 is {x} while Burguer 2 is {y}");
            System.Console.WriteLine($"If Burguer 1 is {x} and Burguer 2 is {y} the whole meal is {x+y}");
            System.Console.WriteLine(format);
            System.Console.WriteLine(@"Verbatim with x = {0}", x);
        }
    }
}
