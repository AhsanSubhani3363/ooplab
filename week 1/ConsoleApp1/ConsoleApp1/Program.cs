using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            str = Console.ReadLine();
            Console.WriteLine("you entered ");
            float num = float.Parse(str);
            Console.WriteLine("the number is ");
            Console.Write(num);
        }
    }
}
