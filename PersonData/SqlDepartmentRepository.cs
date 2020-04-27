using System.Collections.Generic;
using DataAccess;
using StoreData.Models;
using DepartmentData.DataDelegates;
using System;

namespace DepartmentData
{
   public class SqlDepartmentRepository : IDepartmentRepository
   {
      private readonly SqlCommandExecutor executor;

      public SqlDepartmentRepository(string connectionString)
      {
         executor = new SqlCommandExecutor(connectionString);
      }

      //public Department CreateDepartment(string firstName, string lastName, string email)
      //{
      //   if (string.IsNullOrWhiteSpace(firstName))
      //      throw new ArgumentException("The parameter cannot be null or empty.", nameof(firstName));

      //   if (string.IsNullOrWhiteSpace(lastName))
      //      throw new ArgumentException("The parameter cannot be null or empty.", nameof(lastName));

      //   if (string.IsNullOrWhiteSpace(email))
      //      throw new ArgumentException("The parameter cannot be null or empty.", nameof(email));

      //   var d = new CreateDepartmentDataDelegate(DepartmentID, StoreID, DepartmentName);
      //   return executor.ExecuteNonQuery(d);
      //}

      public Department FetchDepartment(int DepartmentId)
      {
         var d = new FetchDepartmentDataDelegate(DepartmentId);
         return executor.ExecuteReader(d);
      }

      public Department GetDepartment(string DepartmentName)
      {
         var d = new GetDepartmentDataDelegate(DepartmentName);
         return executor.ExecuteReader(d);
      }

      public IReadOnlyList<Department> RetrieveDepartments()
      {
         return executor.ExecuteReader(new RetrieveDepartmentsDataDelegate());
      }
   }
}
