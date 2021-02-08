using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int n = 100;
            for (i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("All the even numbers are: " + i);
                }
            }
        }
    }
}