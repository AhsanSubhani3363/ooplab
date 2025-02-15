using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace self_assesment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transcation transaction_1 = new Transcation();
            transaction_1.TransactionId = 100;
            transaction_1.ProductName = "cream";
            transaction_1.Amount = 1020;
            transaction_1.Time = "3:05 PM";
            transaction_1.Date = "1/29/2025";

            Transcation transaction2 = new Transcation(transaction_1);
            Console.WriteLine(transaction_1.Date);
            Console.WriteLine(transaction2.Date);
        }
    }
}
