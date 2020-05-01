using System.Collections.Generic;
using DataAccess;
using StoreData.Models;
using EmployeeData.DataDelegates;
using System;
using DepartmentData.DataDelegates;
using PersonData.DataDelegates;

namespace EmployeeData
{
   public class SqlEmployeeRepository : IEmployeeRepository
   {
        private readonly SqlCommandExecutor executor;

        public SqlEmployeeRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

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

        public Employee CreateEmployee(string employeeName, string workPositionName, string departmentName, double hourlyPay)
        {
            if (string.IsNullOrWhiteSpace(employeeName))
            throw new ArgumentException("The parameter cannot be null or empty.", nameof(employeeName));

            if (string.IsNullOrWhiteSpace(workPositionName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(workPositionName));

            if (string.IsNullOrWhiteSpace(departmentName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(departmentName));

            var d = new CreateEmployeeDataDelegate(employeeName, workPositionName, departmentName, hourlyPay);
            return executor.ExecuteNonQuery(d);
        }

        public IReadOnlyList<Employee> RetrieveEmployeesInDepartment(int departmentID)
        {
            var d = new RetrieveEmployeesInDepartmentDataDelegate(departmentID);
            return executor.ExecuteReader(d);
        }
    }
}
