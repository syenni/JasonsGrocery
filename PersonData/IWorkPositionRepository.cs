using System.Collections.Generic;
using StoreData.Models;

namespace WorkPositionData
{
   public interface IWorkPositionRepository
   {
      /// <summary>
      /// Retrieves all WorkPositions in the database.
      /// </summary>
      /// <returns>
      /// <see cref="IReadOnlyList{WorkPosition}"/> containing all WorkPositions.
      /// </returns>
      IReadOnlyList<Store> RetrieveWorkPositions();

      /// <summary>
      /// Fetches the WorkPosition with the given <paramref name="WorkPositionId"/> if it exists.
      /// </summary>
      /// <param name="WorkPositionID">Identifier of the WorkPosition to fetch.</param>
      /// <returns>
      /// An instance of <see cref="WorkPosition"/> containing the information of the requested WorkPosition.
      /// </returns>
      /// <exception cref="DataAccess.RecordNotFoundException">
      /// Thrown if <paramref name="WorkPositionId"/> does not exist.
      /// </exception>
      Store FetchWorkPosition(int WorkPositionID);

      /// <summary>
      /// Gets the WorkPosition with the given <paramref name="WorkPositionId"/> if it exists.
      /// </summary>
      /// <param name="email">Name of the WorkPosition to get.</param>
      /// <returns>
      /// An instance of <see cref="WorkPosition"/> containing the information of the requested WorkPosition
      /// if one exists with with the provided <paramref name="email"/>.
      /// If one is not found, <c>null</c> is returned.
      /// </returns>
      Store GetWorkPosition(string WorkPositionName);

      /// <summary>
      /// Creates a new WorkPosition in the repository.
      /// </summary>
      /// <param name="firstName">First name of the WorkPosition to create.</param>
      /// <param name="lastName">Last name of the WorkPosition to create.</param>
      /// <param name="email">Email of the WorkPosition to create.</param>
      /// <returns>
      /// The resulting instance of <see cref="WorkPosition"/>.
      /// </returns>
      Store CreateWorkPosition(string WorkPositionName);
   }
}
