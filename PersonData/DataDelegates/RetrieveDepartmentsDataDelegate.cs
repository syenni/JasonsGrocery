using DataAccess;
using StoreData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DepartmentData.DataDelegates
{
   internal class RetrieveDepartmentsDataDelegate : DataReaderDelegate<IReadOnlyList<Department>>
   {
      public RetrieveDepartmentsDataDelegate()
         : base("Department.RetrieveDepartments")
      {
      }

      public override IReadOnlyList<Department> Translate(SqlCommand command, IDataRowReader reader)
      {
         var Departments = new List<Department>();

         while (reader.Read())
         {
            Departments.Add(new Department(
               reader.GetInt32("DepartmentID"),
               reader.GetInt32("StoreID"),
               reader.GetString("DepartmentName")));
         }

         return Departments;
      }
   }
}