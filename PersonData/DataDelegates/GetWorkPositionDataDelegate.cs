using DataAccess;
using StoreData.Models;
using System.Data.SqlClient;

namespace WorkPositionData.DataDelegates
{
   internal class GetWorkPositionDataDelegate : DataReaderDelegate<WorkPosition>
   {
      private readonly string WorkPositionName;

      public GetWorkPositionDataDelegate(string WorkPositionName)
         : base("WorkPosition.GetWorkPosition")
      {
         this.WorkPositionName = WorkPositionName;
      }

      public override void PrepareCommand(SqlCommand command)
      {
         base.PrepareCommand(command);

         command.Parameters.AddWithValue("WorkPositionName", WorkPositionName);
      }

      public override WorkPosition Translate(SqlCommand command, IDataRowReader reader)
      {
         if (!reader.Read())
            return null;

            return new WorkPosition(
               reader.GetInt32("WorkPositionID"),
               reader.GetValue<double>("HourlyPay"),
               WorkPositionName,
               reader.GetValue<WorkPositionType>("WorkPositionType"));
        }
   }
}