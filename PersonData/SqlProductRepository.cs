using System.Collections.Generic;
using DataAccess;
using StoreData.Models;
using DepartmentData.DataDelegates;
using System;

namespace DepartmentData
{
    public class SqlProductRepository : IProductRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlProductRepository(string connectionString)
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

        public Store FetchProduct(int ProductID)
        {
            var d = new FetchProductDataDelegate(ProdutID);
            return executor.ExecuteReader(d);
        }

        public Store GetProduct(string ProductName)
        {
            var d = new GetProductDataDelegate(ProductName);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Store> RetrieveProductss()
        {
            return executor.ExecuteReader(new RetrieveDepartmentsDataDelegate());
        }
    }
}
