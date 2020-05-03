using System.Collections.Generic;
using DataAccess;
using StoreData.Models;
using EmployeeData.DataDelegates;
using System;
using DepartmentData.DataDelegates;
using PersonData.DataDelegates;

namespace EmployeeData
{
   public class SqlTimeEntryRepository : ITimeEntryRepository
   {
        private readonly SqlCommandExecutor executor;

        public SqlTimeEntryRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public IReadOnlyList<TimeEntry> RetrieveHoursWorked(DateTime date)
        {
            var d = new RetrieveHoursWorkedDataDelegate(date);
            return executor.ExecuteReader(d);
        }
    }
}
