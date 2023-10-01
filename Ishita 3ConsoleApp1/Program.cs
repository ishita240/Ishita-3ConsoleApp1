using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ishita_3ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(30, 0));
            Console.WriteLine(test(25, 5));
            Console.WriteLine(test(20, 30));
            Console.WriteLine(test(20, 25));
            Console.ReadLine();
        }
        public static bool test(int a, int b)
        {
            return a == 30 || b == 30 || (a + b == 30);
        }

    }
}
