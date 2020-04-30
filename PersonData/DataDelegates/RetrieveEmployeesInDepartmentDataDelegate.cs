using DataAccess;
using StoreData.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DepartmentData.DataDelegates
{
   internal class RetrieveEmployeesInDepartmentDataDelegate : DataReaderDelegate<IReadOnlyList<Employee>>
   {
      private readonly int departmentID;

      public RetrieveEmployeesInDepartmentDataDelegate(int departmentID)
         : base("Stores.ListofEmpInCertainDept") //name of procedure
      {
            this.departmentID = departmentID;
      }

      public override void PrepareCommand(SqlCommand command)
      {
         base.PrepareCommand(command);

         var p = command.Parameters.AddWithValue("DepartmentID", departmentID);
         //p.Value = departmentID;
        }
      
      public override IReadOnlyList<Employee> Translate(SqlCommand command, IDataRowReader reader)
      {
         var Employees = new List<Employee>();

         while (reader.Read())
         {
                //product just product id and name (match with select in query)
                Employees.Add(new Employee(
                    reader.GetInt32("EmployeeID"),
                    reader.GetString("EmployeeName"),
                    reader.GetString("PositionName")
                    ));
         }

         return Employees;
      }
   }
}