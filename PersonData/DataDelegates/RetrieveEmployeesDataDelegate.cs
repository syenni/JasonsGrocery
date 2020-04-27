using DataAccess;
using StoreData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeeData.DataDelegates
{
   internal class RetrieveEmployeesDataDelegate : DataReaderDelegate<IReadOnlyList<Employee>>
   {
      public RetrieveEmployeesDataDelegate()
         : base("Employee.RetrieveEmployees")
      {
      }

      public override IReadOnlyList<Employee> Translate(SqlCommand command, IDataRowReader reader)
      {
         var Employees = new List<Employee>();

         while (reader.Read())
         {
            Employees.Add(new Employee(
               reader.GetInt32("EmployeeID"),
               reader.GetValue<DepartmentType>("DepartmentType"),
               reader.GetValue<WorkPositionType>("WorkPositionType"),
               reader.GetString("EmployeeName"),
               reader.GetDateTimeOffset("DateTime").DateTime)
            }

         return Employees;
      }
   }
}