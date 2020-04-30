using DataAccess;
using StoreData.Models;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeData.DataDelegates
{
   internal class FetchEmployeeDataDelegate : DataReaderDelegate<Employee>
   {
      private readonly int EmployeeID;

      public FetchEmployeeDataDelegate(int EmployeeID)
         : base("Employee.FetchEmployee")
      {
         this.EmployeeID = EmployeeID;
      }

      public override void PrepareCommand(SqlCommand command)
      {
         base.PrepareCommand(command);

         var p = command.Parameters.Add("EmployeeID", SqlDbType.Int);
         p.Value = EmployeeID;
      }

      public override Employee Translate(SqlCommand command, IDataRowReader reader)
      {
         if (!reader.Read())
            throw new RecordNotFoundException(EmployeeID.ToString());

            return new Employee(
               EmployeeID,
               reader.GetString("EmployeeName"),
               reader.GetString("PositionName"));
        }
   }
}