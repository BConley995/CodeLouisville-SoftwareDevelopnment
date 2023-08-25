using System.Collections.Generic;

namespace Software1ClassExercise4_PetStorePart3
{
    internal interface IProductLogic
    {
        void AddProduct(Product product);
        List<Product> GetAllProducts();
        List<string> GetOnlyInStockProducts();
        DogLeash GetDogLeashByName(string name);
        CatFood GetCatFoodByName(string name);
    }
}
