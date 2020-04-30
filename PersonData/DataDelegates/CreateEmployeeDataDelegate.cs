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
        private readonly int workPositionID;
        private readonly int departmentID;
        private readonly double hourlyPay;

        public CreateEmployeeDataDelegate(string employeeName, int workPosition, int departmentID, double hourlyPay)
           : base("Person.CreatePerson")
        {
            this.employeeName = employeeName;
            this.workPositionID = workPosition;
            this.departmentID = departmentID;
            this.hourlyPay = hourlyPay;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.AddWithValue("EmployeeName", employeeName);

            p = command.Parameters.AddWithValue("WorkPositionID", workPositionID);

            p = command.Parameters.AddWithValue("DepartmentID", departmentID);

            p = command.Parameters.AddWithValue("HourlyPay", hourlyPay);

            p = command.Parameters.Add("EmployeeId", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Employee Translate(SqlCommand command)
        {
            return new Employee((int)command.Parameters["EmployeeId"].Value, employeeName, workPositionID, departmentID, hourlyPay);
        }
    }
}
