using StoreData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace PersonData.DataDelegates
{
    internal class CreateProductDataDelegate : DataReaderDelegate<Product>
    {
        public readonly int storeID;
        public readonly double unitPrice;
        public readonly int stockQuantity;
        public readonly string productName;
        public readonly DepartmentType departmentType;

        public CreateProductDataDelegate(int storeID, double unitPrice, int stockQuantity, string productName, DepartmentType departmentType)
           : base("Store.CreateDepartment")
        {
            this.storeID = storeID;
            this.unitPrice = unitPrice;
            this.stockQuantity = stockQuantity;
            this.productName = productName;
            this.departmentType = departmentType;
    }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("ProductName", SqlDbType.Int);
            p.Value = storeID;

            p = command.Parameters.Add("ProductName", SqlDbType.Float);
            p.Value = (float)unitPrice;

            p = command.Parameters.Add("ProductName", SqlDbType.Int);
            p.Value = stockQuantity;

            p = command.Parameters.Add("ProductName", SqlDbType.NVarChar);
            p.Value = productName;

            p = command.Parameters.Add("DepartmentType", SqlDbType.NVarChar);
            p.Value = departmentType;

            p = command.Parameters.Add("ProductId", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Product Translate(SqlCommand command)
        {
            //return new Product((int)command.Parameters["DepartmentId"].Value, departmentName);
            return new Product((int)command.Parameters["ProductId"].Value, storeID, departmentType, unitPrice, stockQuantity, productName); //(int)command.Parameters["StoreId"].Value
        }

        public override Product Translate(SqlCommand command, IDataRowReader reader)
        {
            throw new System.NotImplementedException();
        }
    }
}