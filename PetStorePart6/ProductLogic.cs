using System.Collections.Generic;
using System.Linq;

namespace PetStorePart6
{
    internal class ProductLogic : IProductLogic
    {
        private List<Product> _products;

        public ProductLogic()
        {
            _products = new List<Product>
            {
                new CatFood { Name = "Meow Meow", Price = 10.99M, Quantity = 0, Description = "Me OWWW" },
                new DogLeash { Name = "Tether Training Leash", Price = 15.99M, Quantity = 5, Description = "Strong leash for training", LengthInches = 60 },
                new DryCatFood { Name = "Salty Salmon", Price = 12.99M, Quantity = 10, Description = "Chicken flavor" }
            };
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public DogLeash GetDogLeashByName(string name)
        {
            return _products.OfType<DogLeash>().FirstOrDefault(dl => dl.Name == name);
        }

        public CatFood GetCatFoodByName(string name)
        {
            return _products.OfType<CatFood>().FirstOrDefault(cf => cf.Name == name);
        }

        public List<Product> GetOnlyInStockProducts()
        {
            return _products.Where(p => p.Quantity > 0).ToList();
        }

        public decimal GetTotalPriceOfInventory()
        {
            return _products.Where(p => p.Quantity > 0).Select(p => p.Price * p.Quantity).Sum();
        }
    }
}
