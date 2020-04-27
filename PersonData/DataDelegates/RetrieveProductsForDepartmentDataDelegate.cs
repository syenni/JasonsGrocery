using DataAccess;
using StoreData.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DepartmentData.DataDelegates
{
   internal class RetrieveProductsForDepartmentDataDelegate : DataReaderDelegate<IReadOnlyList<Product>>
   {
      private readonly int ProductID;

      public RetrieveProductsForDepartmentDataDelegate(int ProductID)
         : base("Department.RetrieveProductesForDepartment")
      {
         this.ProductID = ProductID;
      }

      public override void PrepareCommand(SqlCommand command)
      {
         base.PrepareCommand(command);

         var p = command.Parameters.Add("ProductID", SqlDbType.Int);
         p.Value = ProductID;
      }
      public override IReadOnlyList<Product> Translate(SqlCommand command, IDataRowReader reader)
      {
         var Products = new List<Product>();

         while (reader.Read())
         {
            Products.Add(new Product(
               ProductID,
               reader.GetInt32("StoreID"),
               reader.GetValue<DepartmentType>("DepartmentType"),
               reader.GetValue<double>("UnitPrice"),
               reader.GetInt32("StockQuantity"),
               reader.GetString("ProductName")));
         }

         return Products;
      }
   }
}