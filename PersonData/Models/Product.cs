using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreData.Models
{
    public class Product
    {
        public int ProductID { get; }
        public int StoreID { get; }
        public int DepartmentID { get; }
        public double UnitPrice { get; }
        public int StockQuantity { get; }
        public string ProductName { get; }
        public string DepartmentName { get; }

        public Product(int productID, int storeID, DepartmentType departmentType, double unitprice, int stockquantity, string productName)
        {
            ProductID = productID;
            StoreID = storeID;
            DepartmentID = (int)departmentType;
            UnitPrice = unitprice;
            StockQuantity = stockquantity;
            ProductName = productName;
        }

        public Product(int departmentID, double unitPrice, string productName)
        {
            this.DepartmentID = departmentID;
            this.UnitPrice = unitPrice;
            this.ProductName = productName;
        }

        public Product(string departmentName, int quantity, string productName)
        {
            this.DepartmentName = departmentName;
            this.StockQuantity = quantity;
            this.ProductName = productName;
        }

        public Product(int quantity, string productName)
        {
            this.StockQuantity = quantity;
            this.ProductName = productName;
        }
    }
}
