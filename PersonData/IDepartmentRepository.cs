using System.Collections.Generic;
using StoreData.Models;

namespace DepartmentData
{
   public interface IDepartmentRepository
   {
      /// <summary>
      /// Retrieves all Departments in the database.
      /// </summary>
      /// <returns>
      /// <see cref="IReadOnlyList{Department}"/> containing all Departments.
      /// </returns>
      IReadOnlyList<Department> RetrieveDepartments();

      /// <summary>
      /// Fetches the Department with the given <paramref name="DepartmentId"/> if it exists.
      /// </summary>
      /// <param name="DepartmentID">Identifier of the Department to fetch.</param>
      /// <returns>
      /// An instance of <see cref="Department"/> containing the information of the requested Department.
      /// </returns>
      /// <exception cref="DataAccess.RecordNotFoundException">
      /// Thrown if <paramref name="DepartmentId"/> does not exist.
      /// </exception>
      Department FetchDepartment(int DepartmentID);

      /// <summary>
      /// Gets the Department with the given <paramref name="DepartmentId"/> if it exists.
      /// </summary>
      /// <param name="email">Name of the Department to get.</param>
      /// <returns>
      /// An instance of <see cref="Department"/> containing the information of the requested Department
      /// if one exists with with the provided <paramref name="email"/>.
      /// If one is not found, <c>null</c> is returned.
      /// </returns>
      Department GetDepartment(string DepartmentName);

      /// <summary>
      /// Creates a new Department in the repository.
      /// </summary>
      /// <param name="firstName">First name of the Department to create.</param>
      /// <param name="lastName">Last name of the Department to create.</param>
      /// <param name="email">Email of the Department to create.</param>
      /// <returns>
      /// The resulting instance of <see cref="Department"/>.
      /// </returns>
      /// 
      //Store CreateDepartment(string DepartmentName);
   }
}
