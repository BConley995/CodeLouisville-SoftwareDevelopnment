using System.Collections.Generic;
using System.Linq;
using FluentValidation;

namespace PetStorePart8
{
    public class ProductLogic : IProductLogic
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
            if(product is DogLeash)
            {
                var validator = new DogLeashValidator();
                var results = validator.Validate(product as DogLeash);

                if (!results.IsValid)
                    throw new ValidationException(results.Errors);
            }

            _products.Add(product);
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public T GetProductByName<T>(string name) where T : Product
        {
            return _products.OfType<T>().FirstOrDefault(p => p.Name == name);
        }

        public DogLeash GetDogLeashByName(string name)
        {
            return GetProductByName<DogLeash>(name);
        }


        public CatFood GetCatFoodByName(string name)
        {
            return _products.OfType<CatFood>().FirstOrDefault(cf => cf.Name == name);
        }

        public List<Product> GetOnlyInStockProducts()
        {
            return _products.InStock().ToList();
        }

        public decimal GetTotalPriceOfInventory()
        {
            return _products.InStock().Select(p => p.Price).Sum();
        }
    }
}
