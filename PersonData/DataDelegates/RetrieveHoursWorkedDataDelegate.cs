using DataAccess;
using StoreData.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System;

namespace DepartmentData.DataDelegates
{
   internal class RetrieveHoursWorkedDataDelegate : DataReaderDelegate<IReadOnlyList<TimeEntry>>
   {
        private readonly DateTime date;

      public RetrieveHoursWorkedDataDelegate(DateTime date)
         : base("Stores.HoursWorked") //name of procedure
      {
            this.date = date;
      }

      public override void PrepareCommand(SqlCommand command)
      {
         base.PrepareCommand(command);

         var p = command.Parameters.AddWithValue("SelectedDate", date);
         //p.Value = departmentID;
        }
      
      public override IReadOnlyList<TimeEntry> Translate(SqlCommand command, IDataRowReader reader)
      {
         var Employees = new List<TimeEntry>();

         while (reader.Read())
         {
                //product just product id and name (match with select in query)
                Employees.Add(new TimeEntry(
                    reader.GetString("EmployeeName"),
                    reader.GetInt32("HoursWorked")
                    ));
         }

         return Employees;
      }
   }
}