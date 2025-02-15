using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passfail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            float marks;
            Console.WriteLine("enter marks ");
            input= Console.ReadLine();
            marks=float.Parse(input);
            if(marks>50)
            {
                Console.WriteLine("you are passed ");

            }
            else
            {
                Console.WriteLine("you are failed ");

            }

        }
    }
}
