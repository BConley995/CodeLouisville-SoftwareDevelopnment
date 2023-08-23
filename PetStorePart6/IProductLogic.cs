using System.Collections.Generic;

namespace PetStorePart6
{
    internal interface IProductLogic
    {      
        /// Adds a product to the collection.       
        void AddProduct(Product product);       
        /// Retrieves all products.      
        List<Product> GetAllProducts();
      
        /// Retrieves a DogLeash product by its name.       
        DogLeash GetDogLeashByName(string name);
      
        /// Retrieves a CatFood product by its name.       
        CatFood GetCatFoodByName(string name);
       
        /// Retrieves a only In Stock products by name.      
        List<Product> GetOnlyInStockProducts();

        /// Displays total price of all in stock inventory.      
        decimal GetTotalPriceOfInventory();
    }
}
