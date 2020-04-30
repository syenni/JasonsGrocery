using System.Collections.Generic;
using StoreData.Models;

namespace ProductData
{
   public interface IProductRepository
   {
        /// <summary>
        /// Retrieves all Products in the database.
        /// </summary>
        /// <returns>
        /// <see cref="IReadOnlyList{Product}"/> containing all Products.
        /// </returns>
        IReadOnlyList<Product> RetrieveProducts(int departmentID);

        IReadOnlyList<Product> RetrieveProductsUnderCount(int quantity);

        /// <summary>
        /// Fetches the Product with the given <paramref name="ProductId"/> if it exists.
        /// </summary>
        /// <param name="ProductID">Identifier of the Product to fetch.</param>
        /// <returns>
        /// An instance of <see cref="Product"/> containing the information of the requested Product.
        /// </returns>
        /// <exception cref="DataAccess.RecordNotFoundException">
        /// Thrown if <paramref name="ProductId"/> does not exist.
        /// </exception>
        Product FetchProduct(int ProductID);

        /// <summary>
        /// Gets the Product with the given <paramref name="ProductId"/> if it exists.
        /// </summary>
        /// <param name="email">Name of the Product to get.</param>
        /// <returns>
        /// An instance of <see cref="Product"/> containing the information of the requested Product
        /// if one exists with with the provided <paramref name="email"/>.
        /// If one is not found, <c>null</c> is returned.
        /// </returns>
        Product GetProduct(string ProductName);



        /// <summary>
        /// Creates a new Product in the repository.
        /// </summary>
        /// <param name="firstName">First name of the Product to create.</param>
        /// <param name="lastName">Last name of the Product to create.</param>
        /// <param name="email">Email of the Product to create.</param>
        /// <returns>
        /// The resulting instance of <see cref="Product"/>.
        /// </returns>
        //Store CreateProduct(string ProductName);
   }
}
