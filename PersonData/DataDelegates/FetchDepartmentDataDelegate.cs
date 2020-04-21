using DataAccess;
using StoreData.Models;
using System.Data;
using System.Data.SqlClient;

namespace DepartmentData.DataDelegates
{
   internal class FetchDepartmentDataDelegate : DataReaderDelegate<Department>
   {
      private readonly int DepartmentID;

      public FetchDepartmentDataDelegate(int DepartmentID)
         : base("Department.FetchDepartment")
      {
         this.DepartmentID = DepartmentID;
      }

      public override void PrepareCommand(SqlCommand command)
      {
         base.PrepareCommand(command);

         var p = command.Parameters.Add("DepartmentID", SqlDbType.Int);
         p.Value = DepartmentID;
      }

      public override Department Translate(SqlCommand command, IDataRowReader reader)
      {
         if (!reader.Read())
            throw new RecordNotFoundException(DepartmentID.ToString());

            return new Department(
               DepartmentID,
               reader.GetValue<DepartmentType>("DepartmentType"),
               reader.GetInt32("StoreID"),
               reader.GetString("DepartmentName"));
        }
   }
}