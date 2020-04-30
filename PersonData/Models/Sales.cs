using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreData.Models
{
    public class Sales
    {
        public double UnitPrice { get; }
        public double TotalSales { get; }
        public string ProductName { get; }
        public int AmountOfProductsSold { get; }

        public DateTime Date { get; }

        public Sales(string productName, int amountOfProductsSold, double unitprice, double totalSales)
        {
            this.ProductName = productName;
            this.AmountOfProductsSold = amountOfProductsSold;
            UnitPrice = unitprice;
            TotalSales = totalSales;
        }
    }
}
