using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreData.Models
{
    public class Transaction
    {
        public int TransactionID { get; }
        public int StoreID { get; }
        public DateTime PurchasedOn { get; }

        public Transaction(int transactionID, int storeID, DateTime purchasedOn)
        {
            TransactionID = transactionID;
            StoreID = storeID;
            PurchasedOn = purchasedOn;
        }
    }
}
