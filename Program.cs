using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter first num : ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter second num : ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("the perfect numbers are : ");

            int sum = 0;

            for (int x = n1; x <= n2; x++)
            {
                for (int y = 1; y < x; y++)
                {
                    if (x == 1)
                        continue;

                    if (x % y == 0)
                        sum += y;

                }
                if (sum == x)
                    Console.WriteLine(x);

                sum = 0;

            }
            Console.ReadKey();
        }
    }
}
    