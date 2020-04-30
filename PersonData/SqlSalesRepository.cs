using System.Collections.Generic;
using DataAccess;
using StoreData.Models;
using DepartmentData.DataDelegates;
using System;
using ProductData;
using PersonData.DataDelegates;

namespace DepartmentData
{
    public class SqlSalesRepository : ISalesRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlSalesRepository(string connectionString)
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

        public IReadOnlyList<Sales> RetrieveDailySales(DateTime date)
        {
            var d = new RetrieveDailySalesDataDelegate(date);
            return executor.ExecuteReader(d);
        }
    }
}
