using StoreData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace PersonData.DataDelegates
{
    internal class CreateDepartmentDataDelegate : NonQueryDataDelegate<Department>
    {
        public readonly string departmentName;
        public readonly DepartmentType departmentType;

        public CreateDepartmentDataDelegate(string departmentName, DepartmentType departmentType)
            : base("Store.CreateDepartment")
        {
            this.departmentName = departmentName;
            this.departmentType = departmentType;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("DepartmentName", SqlDbType.NVarChar);
            p.Value = departmentName;

            p = command.Parameters.Add("DepartmentType", SqlDbType.NVarChar);
            p.Value = departmentType;

            p = command.Parameters.Add("DepartmentId", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Department Translate(SqlCommand command)
        {
            return new Department((int)command.Parameters["DepartmentId"].Value, departmentType, (int)command.Parameters["StoreId"].Value, departmentName);
        }
   }
}