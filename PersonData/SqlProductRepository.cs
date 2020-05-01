using System.Collections.Generic;
using DataAccess;
using StoreData.Models;
using DepartmentData.DataDelegates;
using System;
using ProductData;
using PersonData.DataDelegates;

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

        public Product FetchProduct(int ProductID)
        {
            var d = new FetchProductDataDelegate(ProductID);
            return executor.ExecuteReader(d);
        }

        public Product GetProduct(string ProductName)
        {
            var d = new GetProductDataDelegate(ProductName);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Product> RetrieveProductsUnderCount(int quantity)
        {
            var d = new RetrieveProductsForDepartmentUnderCountDataDelegate(quantity);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Product> RetrieveProducts(int departmentID)
        {
            //return executor.ExecuteReader(new RetrieveProductsForDepartmentDataDelegate(ProductID);
            var d = new RetrieveProductsForDepartmentDataDelegate(departmentID);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Product> RetrieveExpensiveProducts(int departmentID)
        {
            //return executor.ExecuteReader(new RetrieveProductsForDepartmentDataDelegate(ProductID);
            var d = new RetrieveExpensiveProductsForDepartmentDataDelegate(departmentID);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Product> RetrieveTop10Products(int departmentID)
        {
            //return executor.ExecuteReader(new RetrieveProductsForDepartmentDataDelegate(ProductID);
            var d = new RetrieveTop5ProductsForDepartmentDataDelegate(departmentID);
            return executor.ExecuteReader(d);
        }
    }
}
