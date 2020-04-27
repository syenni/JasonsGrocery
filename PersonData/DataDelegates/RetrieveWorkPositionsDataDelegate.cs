using DataAccess;
using StoreData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WorkPositionData.DataDelegates
{
   internal class RetrieveWorkPositionsDataDelegate : DataReaderDelegate<IReadOnlyList<WorkPosition>>
   {
      public RetrieveWorkPositionsDataDelegate()
         : base("WorkPosition.RetrieveWorkPositions")
      {
      }

      public override IReadOnlyList<WorkPosition> Translate(SqlCommand command, IDataRowReader reader)
      {
         var WorkPositions = new List<WorkPosition>();

         while (reader.Read())
         {
            WorkPositions.Add(new WorkPosition(
               reader.GetInt32("WorkPositionID"),
               reader.GetValue<double>("HourlyPay"),
               reader.GetString("WorkPositionName"),
               reader.GetValue<WorkPositionType>("WorkPositionType")));
            }

         return WorkPositions;
      }
   }
}