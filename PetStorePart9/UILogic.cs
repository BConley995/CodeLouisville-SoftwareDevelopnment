using System;
using System.Linq;
using System.Text.Json;
using PetStorePart9;
using PetStore.Data;

namespace PetStorePart9
{
    public class UILogic
    {
        private readonly IProductLogic _productLogic;

        internal UILogic(IProductLogic productLogic)
        {
            _productLogic = productLogic;
        }

        public void Start(string[] args)
        {
            bool exitRequested = args.Any(arg => arg.Equals("--exit", StringComparison.OrdinalIgnoreCase));

            while (!exitRequested)
            {
                PrintMenu();
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "exit") break;

                HandleUserInput(userInput);
            }
        }

        private void HandleUserInput(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    AddProduct();
                    break;
                case "2":
                    DisplayProductById();
                    break;
                case "3":
                    DisplayAllProducts();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        private void PrintMenu()
        {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("1. Add product");
            Console.WriteLine("2. View product by ID");
            Console.WriteLine("3. View all products");
            Console.WriteLine("Type 'exit' to quit");
            Console.Write("Enter choice: ");
        }

        private void AddProduct()
        {
            Product product = PromptForProductDetails(new Product());
            _productLogic.AddProduct(product);
            Console.WriteLine("Product added successfully!");
        }

        private Product PromptForProductDetails(Product product)
        {
            Console.Write("Enter product name: ");
            product.Name = Console.ReadLine();

            Console.Write("Enter product price: ");
            if (decimal.TryParse(Console.ReadLine(), out var price)) product.Price = price;

            Console.Write("Enter product quantity: ");
            if (int.TryParse(Console.ReadLine(), out var quantity)) product.Quantity = quantity;

            Console.Write("Enter product description: ");
            product.Description = Console.ReadLine();

            return product;
        }

        private void DisplayProductById()
        {
            Console.Write("Enter product ID: ");
            int id;
            if (int.TryParse(Console.ReadLine(), out id))
            {
                var product = _productLogic.GetProductById(id);
                DisplayProductDetails(product);
            }
            else
            {
                Console.WriteLine("Invalid ID.");
            }
        }

        private void DisplayAllProducts()
        {
            var products = _productLogic.GetAllProducts();
            if (products.Any())
            {
                Console.WriteLine("Products:");
                foreach (var product in products)
                    Console.WriteLine(product.Name);
            }
            else
                Console.WriteLine("No products found.");
        }

        private void DisplayProductDetails(Product product)
        {
            if (product != null)
                Console.WriteLine(JsonSerializer.Serialize(product, new JsonSerializerOptions { WriteIndented = true }));
            else
                Console.WriteLine("Product not found.");
        }
    }
}
