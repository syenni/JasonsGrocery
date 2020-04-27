using DataAccess;
using StoreData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace PersonData.DataDelegates
{
    internal class FetchProductDataDelegate : DataReaderDelegate<Product>
    {
        private readonly int ProductID;

        public FetchProductDataDelegate(int ProductID)
           : base("Department.FetchDepartment")
        {
            this.ProductID = ProductID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("DepartmentID", SqlDbType.Int);
            p.Value = ProductID;
        }

        public override Product Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(ProductID.ToString());

            return new Product(
               ProductID,
               reader.GetInt32("StoreID"),
               reader.GetValue<DepartmentType>("DepartmentType"),
               reader.GetValue<Double>("UnitPrice"),
               reader.GetInt32("StockQuantity"),
               reader.GetString("ProductName"));
        }
    }
}
