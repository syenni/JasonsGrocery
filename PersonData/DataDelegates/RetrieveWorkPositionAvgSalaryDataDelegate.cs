using DataAccess;
using StoreData.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DepartmentData.DataDelegates
{
   internal class RetrieveWorkPositionAvgSalaryDataDelegate : DataReaderDelegate<IReadOnlyList<WorkPosition>>
   {


      public RetrieveWorkPositionAvgSalaryDataDelegate()
         : base("Stores.AvgEmpSalary") //name of procedure
      {

      }

      
      public override IReadOnlyList<WorkPosition> Translate(SqlCommand command, IDataRowReader reader)
      {
         var workPositions = new List<WorkPosition>();

         while (reader.Read())
         {
                //product just product id and name (match with select in query)
                workPositions.Add(new WorkPosition(
                    reader.GetString("PositionName"),
                    reader.GetValue<double>("AverageHourlyPay")
                    ));
         }

         return workPositions;
      }
   }
}