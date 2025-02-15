using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            do
            {
                Console.WriteLine("enter number ");
                num = int.Parse(Console.ReadLine());
                sum = sum + num;
            } while (num != -1);
            sum++;
            Console.WriteLine("the total sum is {0}",sum);
        }
    }
}
