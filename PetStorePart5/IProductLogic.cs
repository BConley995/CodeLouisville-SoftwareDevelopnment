using System.Collections.Generic;

namespace PetStorePart5
{
    internal interface IProductLogic
    {
        void AddProduct(Product product);
        List<Product> GetAllProducts();
        DogLeash GetDogLeashByName(string name);
        CatFood GetCatFoodByName(string name);
        List<Product> GetOnlyInStockProducts();
        List<Product> GetInStockProductObjects();
        decimal GetTotalPriceOfInventory();
    }
}
