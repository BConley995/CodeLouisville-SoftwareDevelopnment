using System.Collections.Generic;
using FluentValidation;
using PetStore.Data;
using PetStore.Data.Repositories;

namespace PetStorePart9
{
    public class ProductLogic : IProductLogic
    {
        private readonly IProductRepository _productRepository;

        public ProductLogic(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void AddProduct(Product product)
        {
            var validator = new ProductValidator();
            var results = validator.Validate(product);

            if (!results.IsValid)
                throw new ValidationException(results.Errors);

            _productRepository.AddProduct(product);
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetProductById(id);
        }
    }
}
