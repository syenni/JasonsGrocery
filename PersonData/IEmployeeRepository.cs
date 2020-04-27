using System.Collections.Generic;
using StoreData.Models;

namespace EmployeeData
{
   public interface IEmployeeRepository
   {
      /// <summary>
      /// Retrieves all employees in the database.
      /// </summary>
      /// <returns>
      /// <see cref="IReadOnlyList{Employee}"/> containing all Employees.
      /// </returns>
      IReadOnlyList<Store> RetrieveEmployees();

      /// <summary>
      /// Fetches the Employee with the given <paramref name="EmployeeId"/> if it exists.
      /// </summary>
      /// <param name="EmployeeID">Identifier of the Employee to fetch.</param>
      /// <returns>
      /// An instance of <see cref="Employee"/> containing the information of the requested Employee.
      /// </returns>
      /// <exception cref="DataAccess.RecordNotFoundException">
      /// Thrown if <paramref name="EmployeeId"/> does not exist.
      /// </exception>
      Store FetchEmployee(int EmployeeID);

      /// <summary>
      /// Gets the Employee with the given <paramref name="EmployeeId"/> if it exists.
      /// </summary>
      /// <param name="email">Name of the Employee to get.</param>
      /// <returns>
      /// An instance of <see cref="Employee"/> containing the information of the requested Employee
      /// if one exists with with the provided <paramref name="email"/>.
      /// If one is not found, <c>null</c> is returned.
      /// </returns>
      Store GetEmployee(string EmployeeName);

      /// <summary>
      /// Creates a new Employee in the repository.
      /// </summary>
      /// <param name="firstName">First name of the Employee to create.</param>
      /// <param name="lastName">Last name of the Employee to create.</param>
      /// <param name="email">Email of the Employee to create.</param>
      /// <returns>
      /// The resulting instance of <see cref="Employee"/>.
      /// </returns>
      Store CreateEmployee(string EmployeeName);
   }
}
