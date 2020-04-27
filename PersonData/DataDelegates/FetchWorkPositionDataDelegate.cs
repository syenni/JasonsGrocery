using DataAccess;
using StoreData.Models;
using System.Data;
using System.Data.SqlClient;

namespace WorkPositionData.DataDelegates
{
   internal class FetchWorkPositionDataDelegate : DataReaderDelegate<WorkPosition>
   {
      private readonly int WorkPositionID;

      public FetchWorkPositionDataDelegate(int WorkPositionID)
         : base("WorkPosition.FetchWorkPosition")
      {
         this.WorkPositionID = WorkPositionID;
      }

      public override void PrepareCommand(SqlCommand command)
      {
         base.PrepareCommand(command);

         var p = command.Parameters.Add("WorkPositionID", SqlDbType.Int);
         p.Value = WorkPositionID;
      }

      public override WorkPosition Translate(SqlCommand command, IDataRowReader reader)
      {
         if (!reader.Read())
            throw new RecordNotFoundException(WorkPositionID.ToString());

            return new WorkPosition(
               WorkPositionID,
               reader.GetValue<double>("HourlyPay"),
               reader.GetString("PositionName"),
               reader.GetValue<WorkPositionType>("WorkPositionType"));
        }
   }
}