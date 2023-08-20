using System.Collections.Generic;
using System.Linq;

namespace PetStorePart4
{
    internal class ProductLogic : IProductLogic
    {
        private List<Product> _products;
        private Dictionary<string, DogLeash> _dogLeash;
        private Dictionary<string, CatFood> _catFood;

        public ProductLogic()
        {
            _products = new List<Product>
                 {
        new CatFood { Name = "Meow Meow", Price = 10.99M, Quantity = 0, Description = "Me OWWW" },
        new DogLeash { Name = "Tether Training Leash", Price = 15.99M, Quantity = 5, Description = "Strong leash for training", LengthInches = 60 },
        new DryCatFood { Name = "Salty Salmon", Price = 12.99M, Quantity = 10, Description = "Chicken flavor" }
    };
            _dogLeash = new Dictionary<string, DogLeash>();
            _catFood = new Dictionary<string, CatFood>();
        }

        public void AddProduct(Product product)
        {
            if (product is DogLeash)
            {
                _dogLeash.Add(product.Name, product as DogLeash);
            }
            if (product is CatFood)
            {
                _catFood.Add(product.Name, product as CatFood);
            }
            _products.Add(product);
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public DogLeash GetDogLeashByName(string name)
        {
            try
            {
                return _dogLeash[name];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public CatFood GetCatFoodByName(string name)
        {
            _catFood.TryGetValue(name, out CatFood catFood);
            return catFood;
        }

        public List<Product> GetOnlyInStockProducts()
        {
            return _products.Where(p => p.Quantity > 0).ToList();
        }


        public decimal GetTotalPriceOfInventory()
        {
            return _products.Where(p => p.Quantity > 0).Select(p => p.Price * p.Quantity).Sum();
        }

        public List<Product> GetInStockProductObjects()
        {
            return _products.Where(p => p.Quantity > 0).ToList();
        }


    }
}