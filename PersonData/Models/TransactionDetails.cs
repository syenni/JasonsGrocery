using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreData.Models
{
    public class TransactionDetails
    {
        public int TransactionID { get; }
        public int ProductID { get; }
        public int StoreID { get; }
        public double UnitPrice { get; }
        public int ItemQuantity { get; }
        public TransactionDetails(int transactionID, int productID, int storeID, double unitPrice, int itemQuantity)
        {
            TransactionID = transactionID;
            ProductID = productID;
            StoreID = storeID;
            UnitPrice = unitPrice;
            ItemQuantity = itemQuantity;
        }
    }
}
