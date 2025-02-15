using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace int_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            str=Console.ReadLine();
            Console.WriteLine("you entered ");
            int num=int.Parse(str);
            Console.WriteLine("the number is ");
            Console.Write(num);
        }
    }
}
