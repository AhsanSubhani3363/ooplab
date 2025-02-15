using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace self_assesment_1
{
    internal class Transcation
    {
        public int TransactionId;
        public string ProductName;
        public int Amount;
        public string Date;
        public string Time;

        public Transcation()
        {

        }

        public Transcation(Transcation transation)
        {
            TransactionId = transation.TransactionId;
            ProductName = transation.ProductName;
            Amount = transation.Amount;
            Date = transation.Date;
            Time = transation.Time;
        }
    }
}
    

