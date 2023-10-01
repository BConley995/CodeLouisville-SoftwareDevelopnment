using System.Collections.Generic;

namespace PetStore.Data.Repositories
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        Product GetProductById(int id);
        List<Product> GetAllProducts();
    }
}
