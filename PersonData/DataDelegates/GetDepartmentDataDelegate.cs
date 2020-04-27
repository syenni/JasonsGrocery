using DataAccess;
using StoreData.Models;
using System.Data.SqlClient;

namespace DepartmentData.DataDelegates
{
   internal class GetDepartmentDataDelegate : DataReaderDelegate<Department>
   {
      private readonly string departmentName;

      public GetDepartmentDataDelegate(string departmentName)
         : base("Department.GetDepartment")
      {
         this.departmentName = departmentName;
      }

      public override void PrepareCommand(SqlCommand command)
      {
         base.PrepareCommand(command);

         command.Parameters.AddWithValue("DepartmentName", departmentName);
      }

      public override Department Translate(SqlCommand command, IDataRowReader reader)
      {
         if (!reader.Read())
            return null;

            return new Department(
               reader.GetInt32("DepartmentID"),
               reader.GetValue<DepartmentType>("DepartmentType"),
               reader.GetInt32("StoreID"),
               departmentName); //reader.GetString("DepartmentName"));
      }
   }
}