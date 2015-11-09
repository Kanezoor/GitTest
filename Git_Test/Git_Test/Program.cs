using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=6;
            int b = 32;
            bool v = false;
            if (a < b)
                v = true;

            if (v)
                v = false;
            GitTest test = new GitTest();
            test.a = Convert.ToInt32(Console.ReadLine());
            test.b = Convert.ToInt32(Console.ReadLine());
            test.Addx(test.a, test.b);
            Console.WriteLine(test.c);
            Console.WriteLine(test.multi());

        }
    }
}
