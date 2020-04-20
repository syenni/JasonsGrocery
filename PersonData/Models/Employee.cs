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
        public int WorkPositionID { get;}
        public string EmployeeName { get; }
        public DateTime StartDate { get; }

        public Employee(int employeeID, DepartmentType departmentType, WorkPositionType workPosition, string employeeName, DateTime startDate)
        {
            EmployeeID = employeeID;
            DepartmentID = (int)departmentType;
            WorkPositionID = (int)workPosition;
            EmployeeName = employeeName;
            StartDate = startDate;
        }
    }
}
