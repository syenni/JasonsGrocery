using DataAccess;
using StoreData.Models;
using System.Data.SqlClient;

namespace EmployeeData.DataDelegates
{
   internal class GetEmployeeDataDelegate : DataReaderDelegate<Employee>
   {
      private readonly string employeeName;

      public GetEmployeeDataDelegate(string employeeName)
         : base("Employee.GetEmployee")
      {
         this.employeeName = employeeName;
      }

      public override void PrepareCommand(SqlCommand command)
      {
         base.PrepareCommand(command);

         command.Parameters.AddWithValue("EmployeeName", employeeName);
      }

      public override Employee Translate(SqlCommand command, IDataRowReader reader)
      {
         if (!reader.Read())
            return null;

            return new Employee(
               reader.GetInt32("EmployeeID"),
               reader.GetValue<DepartmentType>("DepartmentType"),
               reader.GetValue<WorkPositionType>("WorkPositionType"),
               employeeName,
               reader.GetDateTimeOffset("DateTime").DateTime);
        }
   }
}