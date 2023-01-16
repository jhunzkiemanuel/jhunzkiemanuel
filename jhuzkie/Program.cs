using System;
using System.Diagnostics;

namespace jhunzkie
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("enter any name: ");
            string name = Console.ReadLine().ToUpper();
            char[] charN = name.ToCharArray();

            for (int a = 0; a <=(charN.Length - 1)/2; a++)
            {
                for (int spc = 0; spc <= a; spc++)
                {
                    Console.Write(" ");
                }

                for (int b = a; b <= (charN.Length - 1) - a; b++)
                {
                    Console.Write(charN[b]);
                }

                Console.ReadLine();
            }
        }
    }
}