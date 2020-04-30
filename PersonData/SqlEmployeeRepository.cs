using System.Collections.Generic;
using DataAccess;
using StoreData.Models;
using EmployeeData.DataDelegates;
using System;
using DepartmentData.DataDelegates;

namespace EmployeeData
{
   public class SqlEmployeeRepository : IEmployeeRepository
   {
      private readonly SqlCommandExecutor executor;

      public SqlEmployeeRepository(string connectionString)
      {
         executor = new SqlCommandExecutor(connectionString);
      }

      //public Employee CreateEmployee(string firstName, string lastName, string email)
      //{
      //   if (string.IsNullOrWhiteSpace(firstName))
      //      throw new ArgumentException("The parameter cannot be null or empty.", nameof(firstName));

      //   if (string.IsNullOrWhiteSpace(lastName))
      //      throw new ArgumentException("The parameter cannot be null or empty.", nameof(lastName));

      //   if (string.IsNullOrWhiteSpace(email))
      //      throw new ArgumentException("The parameter cannot be null or empty.", nameof(email));

      //   var d = new CreateEmployeeDataDelegate(EmployeeID, StoreID, EmployeeName);
      //   return executor.ExecuteNonQuery(d);
      //}

      public Employee FetchEmployee(int EmployeeId)
      {
         var d = new FetchEmployeeDataDelegate(EmployeeId);
         return executor.ExecuteReader(d);
      }

      public Employee GetEmployee(string EmployeeName)
      {
         var d = new GetEmployeeDataDelegate(EmployeeName);
         return executor.ExecuteReader(d);
      }

      public IReadOnlyList<Employee> RetrieveEmployeesInDepartment(int departmentID)
      {
            var d = new RetrieveEmployeesInDepartmentDataDelegate(departmentID);
            return executor.ExecuteReader(d);
        }
   }
}
