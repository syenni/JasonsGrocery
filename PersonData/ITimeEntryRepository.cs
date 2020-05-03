using System.Collections.Generic;
using StoreData.Models;
using System;

namespace EmployeeData
{
   public interface ITimeEntryRepository
   {
        IReadOnlyList<TimeEntry> RetrieveHoursWorked(DateTime date);
    }
}
