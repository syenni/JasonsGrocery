using DataAccess;
using StoreData.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DepartmentData.DataDelegates
{
   internal class RetrieveProductsForDepartmentUnderCountDataDelegate : DataReaderDelegate<IReadOnlyList<Product>>
   {
        private readonly int departmentID;
        private readonly int quantity;

        public RetrieveProductsForDepartmentUnderCountDataDelegate(int departmentID, int quantity)
            : base("Stores.ItemsInDept") //name of procedure
        {
            this.departmentID = departmentID;
            this.quantity = quantity;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.AddWithValue("DepartmentID", departmentID);
            var p1 = command.Parameters.AddWithValue("Quantity", quantity);
            //p.Value = departmentID;
        }
      
        public override IReadOnlyList<Product> Translate(SqlCommand command, IDataRowReader reader)
        {
            var Products = new List<Product>();

            while (reader.Read())
            {
                //product just product id and name (match with select in query)
                Products.Add(new Product(
                    departmentID,
                    reader.GetInt32("StockQuantity"),
                    reader.GetString("ProductName")
                    ));

            }

            return Products;
        }
    }
}