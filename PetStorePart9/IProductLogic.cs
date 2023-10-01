using System.Collections.Generic;
using PetStore.Data;

namespace PetStorePart9
{
    internal interface IProductLogic
    {
        void AddProduct(Product product);
        List<Product> GetAllProducts();
        Product GetProductById(int id);
    }
}
