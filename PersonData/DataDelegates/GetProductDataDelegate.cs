using DataAccess;
using StoreData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using StoreData.Models;
using System.Data.SqlClient;

namespace PersonData.DataDelegates
{
    internal class GetProductDataDelegate : DataReaderDelegate<Product>
    {
        private readonly string productName;

        public GetProductDataDelegate(string productName)
         : base("Department.GetDepartment")
        {
            this.productName = productName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("ProductName", productName);
        }

        public override Product Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Product(
               reader.GetInt32("ProductID"),
               reader.GetInt32("StoreID"),
               reader.GetValue<DepartmentType>("DepartmentType"),
               reader.GetValue<double>("UnitPrice"),
               reader.GetInt32("StockQuantity"),
               productName);
        }
    }
}
