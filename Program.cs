using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3x1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i< 999999; i++)
            {
                Console.WriteLine($"\ni = {i}");

                DidYouMeanRecursion(i);
            }
        }

        static void DidYouMeanRecursion(int i)
        {
            if (i == 1)
                return;

            if (i % 2 == 0)
            {
                int x = i / 2;
                Console.Write($"{x},");
                DidYouMeanRecursion(x);
            }
            else
            {
                int x = 3 * i + 1;
                Console.Write($"{x},");
                DidYouMeanRecursion(x);
            }
        }
    }
}
