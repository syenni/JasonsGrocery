using System.Collections.Generic;
using DataAccess;
using StoreData.Models;
using WorkPositionData.DataDelegates;
using System;

namespace WorkPositionData
{
   public class SqlWorkPositionRepository : IWorkPositionRepository
   {
      private readonly SqlCommandExecutor executor;

      public SqlWorkPositionRepository(string connectionString)
      {
         executor = new SqlCommandExecutor(connectionString);
      }

      //public WorkPosition CreateWorkPosition(string firstName, string lastName, string email)
      //{
      //   if (string.IsNullOrWhiteSpace(firstName))
      //      throw new ArgumentException("The parameter cannot be null or empty.", nameof(firstName));

      //   if (string.IsNullOrWhiteSpace(lastName))
      //      throw new ArgumentException("The parameter cannot be null or empty.", nameof(lastName));

      //   if (string.IsNullOrWhiteSpace(email))
      //      throw new ArgumentException("The parameter cannot be null or empty.", nameof(email));

      //   var d = new CreateWorkPositionDataDelegate(WorkPositionID, StoreID, WorkPositionName);
      //   return executor.ExecuteNonQuery(d);
      //}

      public WorkPosition FetchWorkPosition(int WorkPositionId)
      {
         var d = new FetchWorkPositionDataDelegate(WorkPositionId);
         return executor.ExecuteReader(d);
      }

      public WorkPosition GetWorkPosition(string WorkPositionName)
      {
         var d = new GetWorkPositionDataDelegate(WorkPositionName);
         return executor.ExecuteReader(d);
      }

      public IReadOnlyList<WorkPosition> RetrieveWorkPositions()
      {
         return executor.ExecuteReader(new RetrieveWorkPositionsDataDelegate());
      }
   }
}
