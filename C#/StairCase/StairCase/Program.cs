using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StairCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                for(int j = 0; j<n-i; j++)
                {
                    Console.Write(" ");
                }
                for(int j=0; j<i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
