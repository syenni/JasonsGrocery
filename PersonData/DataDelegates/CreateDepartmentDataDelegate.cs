using StoreData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace PersonData.DataDelegates
{
   internal class CreateDepartmentDataDelegate : NonQueryDataDelegate<Store>
   {
      public readonly string departmentName;

      public CreateDepartmentDataDelegate(string departmentName)
         : base("Store.CreateDepartment")
      {
         this.departmentName = departmentName;
      }

      public override void PrepareCommand(SqlCommand command)
      {
         base.PrepareCommand(command);

         var p = command.Parameters.Add("DepartmentName", SqlDbType.NVarChar);
         p.Value = departmentName;

         p = command.Parameters.Add("DepartmentId", SqlDbType.Int);
         p.Direction = ParameterDirection.Output;
      }

      public override Store Translate(SqlCommand command)
      {
         return new Store((int)command.Parameters["DepartmentId"].Value, departmentName);
      }
   }
}