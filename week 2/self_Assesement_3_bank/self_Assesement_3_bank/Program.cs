using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace self_Assesement_3_bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM obj1 = new ATM();
            obj1.CheckBalance();
            obj1.depositCash(500);
            obj1.depositCash(750);
            obj1.WithDrawCash(300);
            obj1.WithDrawCash(100);
            obj1.CheckBalance();
            obj1.WithDrawCash(2000);
            obj1.CheckBalance();
            obj1.History();
            Console.ReadKey();
        
    }
    }
}
