using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, sum = 0;
            Console.WriteLine("enter number ");
            number=int.Parse(Console.ReadLine());
            while (number!=-1)
            {
                sum = sum + number;
                Console.WriteLine("enter number ");
                number = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("sum is {0}", sum);
            Console.Read();
        }
    }
}
