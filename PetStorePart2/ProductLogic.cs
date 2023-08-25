using System.Collections.Generic;
using System.Linq;

namespace Software1ClassExercise3_PetStorePart2
{
    public class ProductLogic
    {
        private List<Product> _products;
        private Dictionary<string, DogLeash> _dogLeashes;
        private Dictionary<string, CatFood> _catFoods;

        public ProductLogic()
        {
            _products = new List<Product>();
            _dogLeashes = new Dictionary<string, DogLeash>();
            _catFoods = new Dictionary<string, CatFood>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);

            if (product is DogLeash dogLeash)
            {
                _dogLeashes.Add(product.Name, dogLeash);
            }
            else if (product is CatFood catFood)
            {
                _catFoods.Add(product.Name, catFood);
            }
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public DogLeash GetDogLeashByName(string name)
        {
            return _dogLeashes.ContainsKey(name) ? _dogLeashes[name] : null;
        }

        public CatFood GetCatFoodByName(string name)
        {
            return _catFoods.ContainsKey(name) ? _catFoods[name] : null;
        }
    }
}
