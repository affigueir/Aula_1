using System;

namespace Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*foreach ( string a in args)
                Console.WriteLine(a);*/
            for (int i = 0; i < args.Length; i++)
                Console.WriteLine(args[i]);
        }
    }
}
