using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start_num, end_num;

            Console.Write("Enter the start number of range: ");
            start_num = int.Parse(Console.ReadLine());

            Console.Write("Enter the end number of range: ");
            end_num = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            Console.WriteLine("prime numbers in given range are :");

            for (int i = start_num; i <= end_num; i++)
            {
                bool is_prime = true;
                
                if (i == 1)
                {
                    continue;
                }

                for (int t = 2; t < i; t++)
                {
                    if (i % t == 0)
                    {
                        is_prime = false;
                        break;
                    }
                }

                if (is_prime == true)
                {
                    Console.WriteLine(". \t" + i);
                }
            }
        }
    }
}
