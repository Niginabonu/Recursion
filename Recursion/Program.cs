using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                count += kub(i, n - i);
            }
            Console.WriteLine(count + 1);
            // Console.ReadKey();

        }

        static int kub(int a, int b)
        {
            if (b == 0)
                return 1;

            int count = 0;
            for (int i = 0; i < a; i++)

                if (b - i >= 0)
                    count += kub(i, b - i);
            return count;

        }

    }
}
