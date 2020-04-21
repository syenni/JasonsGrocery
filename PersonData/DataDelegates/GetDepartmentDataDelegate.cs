using DataAccess;
using StoreData.Models;
using System.Data.SqlClient;

namespace DepartmentData.DataDelegates
{
   internal class GetDepartmentDataDelegate : DataReaderDelegate<Department>
   {
      private readonly string email;

      public GetDepartmentDataDelegate(string email)
         : base("Department.GetDepartment")
      {
         this.email = email;
      }

      public override void PrepareCommand(SqlCommand command)
      {
         base.PrepareCommand(command);

         command.Parameters.AddWithValue("Email", email);
      }

      public override Department Translate(SqlCommand command, IDataRowReader reader)
      {
         if (!reader.Read())
            return null;

            return new Department(
               reader.GetInt32("DepartmentID"),
               reader.GetValue<DepartmentType>("DepartmentType"),
               reader.GetInt32("StoreID"),
               reader.GetString("DepartmentName"));
      }
   }
}