using DataAccess;
using StoreData.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DepartmentData.DataDelegates
{
   internal class RetrieveProductsForDepartmentDataDelegate : DataReaderDelegate<IReadOnlyList<Product>>
   {
      private readonly int DepartmentID;

      public RetrieveProductsForDepartmentDataDelegate(int DepartmentID)
         : base("Department.RetrieveProductesForDepartment")
      {
         this.DepartmentID = DepartmentID;
      }

      public override void PrepareCommand(SqlCommand command)
      {
         base.PrepareCommand(command);

         var p = command.Parameters.Add("DepartmentID", SqlDbType.Int);
         p.Value = DepartmentID;
      }
      public override IReadOnlyList<Product> Translate(SqlCommand command, IDataRowReader reader)
      {
         var Products = new List<Product>();

         while (reader.Read())
         {
            Products.Add(new Product(
               reader.GetInt32("ProductID"),
               reader.GetInt32("StoreID"),
               reader.GetValue<DepartmentType>("DepartmentType"),
              // (ProductType)reader.GetByte("ProductTypeId"),
               reader.GetValue<double>("UnitPrice"),
               reader.GetInt32("StockQuantity"),
               reader.GetString("ProductName")));
         }

         return Products;
      }
   }
}