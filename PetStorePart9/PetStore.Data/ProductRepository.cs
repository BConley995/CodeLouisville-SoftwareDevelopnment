using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PetStore.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;

        public ProductRepository()
        {
            _context = new ProductContext();
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine(ex.InnerException?.Message);
                throw;
            }

        }

        public Product GetProductById(int id)
        {
            return _context.Products.Find(id);
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }
    }
}
