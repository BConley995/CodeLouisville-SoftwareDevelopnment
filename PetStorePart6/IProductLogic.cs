using System.Collections.Generic;

namespace PetStorePart6
{
    internal interface IProductLogic
    {
        /// <summary>
        /// Adds a product to the collection.
        /// </summary>
        void AddProduct(Product product);

        /// <summary>
        /// Retrieves all products.
        /// </summary>
        List<Product> GetAllProducts();

        /// <summary>
        /// Retrieves a DogLeash product by its name.
        /// </summary>
        DogLeash GetDogLeashByName(string name);

        /// <summary>
        /// Retrieves a CatFood product by its name.
        /// </summary>
        CatFood GetCatFoodByName(string name);

        /// <summary>
        /// Retrieves a only In Stock products by name.
        /// </summary>
        List<Product> GetOnlyInStockProducts();

        /// <summary>
        /// Displays total price of all in stock inventory.
        /// </summary>
        decimal GetTotalPriceOfInventory();
    }
}
