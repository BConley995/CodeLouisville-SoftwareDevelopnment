using System;
using System.Linq;
using System.Text.Json;
using PetStorePart8;

namespace PetStorePart8
{
    public class UILogic
    {
        private readonly IProductLogic _productLogic;

        internal UILogic(IProductLogic productLogic)
        {
            _productLogic = productLogic;
        }

        public void Start()
        {
            while (true)
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
                    AddWetCatFood();
                    break;
                case "2":
                    AddDryCatFood();
                    break;
                case "3":
                    AddDogLeash();
                    break;
                case "4":
                    DisplayDogLeash();
                    break;
                case "5":
                    DisplayCatFood();
                    break;
                case "6":
                    DisplayInStockProducts();
                    break;
                case "7":
                    DisplayTotalInventoryValue();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        private void PrintMenu()
        {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("1. Add wet cat food");
            Console.WriteLine("2. Add dry cat food");
            Console.WriteLine("3. Add dog leash");
            Console.WriteLine("4. View dog leash by name");
            Console.WriteLine("5. View cat food by name");
            Console.WriteLine("6. View in-stock products");
            Console.WriteLine("7. View total inventory value");
            Console.WriteLine("Type 'exit' to quit");
            Console.Write("Enter choice: ");
        }

        private void AddWetCatFood()
        {
            CatFood catFood = PromptForProductDetails(new CatFood()) as CatFood;
            _productLogic.AddProduct(catFood);
            Console.WriteLine("Wet cat food added successfully!");
        }

        private void AddDryCatFood()
        {
            DryCatFood dryCatFood = PromptForProductDetails(new DryCatFood()) as DryCatFood;
            _productLogic.AddProduct(dryCatFood);
            Console.WriteLine("Dry cat food added successfully!");
        }

        private void AddDogLeash()
        {
            Console.WriteLine("Enter Dog LEash details in JSON format:");
            string jsonString = Console.ReadLine();
            DogLeash dogLeash = JsonSerializer.Deserialize<DogLeash>(jsonString);
            _productLogic.AddProduct(dogLeash);
            Console.WriteLine("Dog leash added successfully!");
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

            if (product is CatFood catFood)
            {
                Console.Write("Enter cat food weight in pounds: ");
                if (double.TryParse(Console.ReadLine(), out var weight)) catFood.WeightPounds = weight;

                Console.Write("Is this kitten food? (yes/no): ");
                catFood.KittenFood = Console.ReadLine().ToLower() == "yes";
            }
            else if (product is DogLeash dogLeash)
            {
                Console.Write("Enter dog leash length in inches: ");
                if (int.TryParse(Console.ReadLine(), out var length)) dogLeash.LengthInches = length;
            }

            return product;
        }

        private void DisplayDogLeash()
        {
            Console.Write("Enter dog leash name: ");
            string name = Console.ReadLine();
            var dogLeash = _productLogic.GetDogLeashByName(name);
            DisplayProductDetails(dogLeash);
        }

        private void DisplayCatFood()
        {
            Console.Write("Enter cat food name: ");
            string name = Console.ReadLine();
            var catFood = _productLogic.GetCatFoodByName(name);
            DisplayProductDetails(catFood);
        }

        private void DisplayProductDetails(Product product)
        {
            if (product != null)
                Console.WriteLine(JsonSerializer.Serialize(product, new JsonSerializerOptions { WriteIndented = true }));
            else
                Console.WriteLine("Product not found.");
        }

        private void DisplayInStockProducts()
        {
            var products = _productLogic.GetOnlyInStockProducts();
            if (products.Any())
            {
                Console.WriteLine("In-stock products:");
                foreach (var product in products) Console.WriteLine(product.Name);
            }
            else Console.WriteLine("No products in stock.");
        }

        private void DisplayTotalInventoryValue()
        {
            Console.WriteLine($"Total inventory value: {_productLogic.GetTotalPriceOfInventory():C}");
        }
    }
}
