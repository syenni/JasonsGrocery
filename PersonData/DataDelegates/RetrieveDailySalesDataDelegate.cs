using DataAccess;
using StoreData.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System;

namespace DepartmentData.DataDelegates
{
   internal class RetrieveDailySalesDataDelegate : DataReaderDelegate<IReadOnlyList<Sales>>
   {
        private readonly DateTime date;

      public RetrieveDailySalesDataDelegate(DateTime date)
         : base("Stores.DailySales") //name of procedure
      {
            this.date = date;
      }

      public override void PrepareCommand(SqlCommand command)
      {
         base.PrepareCommand(command);

         var p = command.Parameters.AddWithValue("SelectedDate", date);
         //p.Value = departmentID;
        }
      
      public override IReadOnlyList<Sales> Translate(SqlCommand command, IDataRowReader reader)
      {
         var Sales = new List<Sales>();

         while (reader.Read())
         {
                //product just product id and name (match with select in query)
                Sales.Add(new Sales(
                    reader.GetString("ProductName"),
                    reader.GetInt32("AmountOfProductsSold"),
                    reader.GetValue<double>("UnitPrice"),
                    reader.GetValue<double>("TotalSales")
                    ));
         }

         return Sales;
      }
   }
}