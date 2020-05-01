using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreData.Models
{
    public class Employee
    {
        public int EmployeeID { get; }
        public int DepartmentID { get; }
        public string DepartmentName { get; }
        public int WorkPositionID { get;}
        public string EmployeeName { get; }
        public DateTime StartDate { get; }
        public string PositionName { get; }
        public double HourlyPay { get; }

        public Employee(int employeeID, string employeeName, string positionName)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            PositionName = positionName;
        }

        public Employee(int employeeID, string workPositionName, string departmentName, double hourlyPay, string employeeName)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            PositionName = workPositionName;
            DepartmentName = departmentName;
            HourlyPay = hourlyPay;
        }
    }
}
