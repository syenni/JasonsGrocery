using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccess;
using StoreData.Models;

namespace PersonData.DataDelegates
{
    class CreateEmployeeDataDelegate: NonQueryDataDelegate<Employee>
    {
        private readonly string employeeName;
        private readonly string workPositionName;
        private readonly string departmentName;
        private readonly double hourlyPay;

        public CreateEmployeeDataDelegate(string employeeName, string workPositionName, string departmentName, double hourlyPay)
           : base("Stores.CreateEmployee")
        {
            this.employeeName = employeeName;
            this.workPositionName = workPositionName;
            this.departmentName = departmentName;
            this.hourlyPay = hourlyPay;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("PositionName", SqlDbType.NVarChar);
            p.Value = workPositionName;

            p = command.Parameters.Add("DepartmentName", SqlDbType.NVarChar);
            p.Value = departmentName;

            p = command.Parameters.Add("HourlyPay", SqlDbType.Float);
            p.Value = hourlyPay;

            p = command.Parameters.Add("EmployeeName", SqlDbType.NVarChar);
            p.Value = employeeName;

            p = command.Parameters.Add("EmployeeID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Employee Translate(SqlCommand command)
        {
            return new Employee((int)command.Parameters["EmployeeID"].Value, workPositionName, departmentName, hourlyPay, employeeName);
        }
    }
}
