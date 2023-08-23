using System;
using System.Linq;
using System.Text.Json;
using PetStorePart6;

namespace PetStorePart6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Initialize product logic
            ProductLogic productLogic = new ProductLogic();

            while (true)
            {
                PrintMenu();
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "exit") break;

                switch (userInput)
                {
                    case "1":
                        AddWetCatFood(productLogic);
                        break;
                    case "2":
                        AddDryCatFood(productLogic);
                        break;
                    case "3":
                        AddDogLeash(productLogic);
                        break;
                    case "4":
                        DisplayDogLeash(productLogic);
                        break;
                    case "5":
                        DisplayCatFood(productLogic);
                        break;
                    case "6":
                        DisplayInStockProducts(productLogic);
                        break;
                    case "7":
                        DisplayTotalInventoryValue(productLogic);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        
        /// Displays the main menu options to the user.     
        static void PrintMenu()
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

        
        /// Prompts the user to add a wet cat food item and saves it.       
        static void AddWetCatFood(ProductLogic logic)
        {
            CatFood catFood = PromptForProductDetails(new CatFood()) as CatFood;
            logic.AddProduct(catFood);
            Console.WriteLine("Wet cat food added successfully!");
        }

        
        /// Prompts the user to add a dry cat food item and saves it.       
        static void AddDryCatFood(ProductLogic logic)
        {
            DryCatFood dryCatFood = PromptForProductDetails(new DryCatFood()) as DryCatFood;
            logic.AddProduct(dryCatFood);
            Console.WriteLine("Dry cat food added successfully!");
        }

        
        /// Prompts the user to add a dog leash item and saves it.       
        static void AddDogLeash(ProductLogic logic)
        {
            DogLeash dogLeash = PromptForProductDetails(new DogLeash()) as DogLeash;
            logic.AddProduct(dogLeash);
            Console.WriteLine("Dog leash added successfully!");
        }

        
        /// Prompts the user for product details based on the type of product.      
        static Product PromptForProductDetails(Product product)
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

        
        /// Displays the details of a specific dog leash based on the given name.      
        static void DisplayDogLeash(ProductLogic logic)
        {
            Console.Write("Enter dog leash name: ");
            string name = Console.ReadLine();
            var dogLeash = logic.GetDogLeashByName(name);
            DisplayProductDetails(dogLeash);
        }

        
        /// Displays the details of a specific cat food item based on the given name.        
        static void DisplayCatFood(ProductLogic logic)
        {
            Console.Write("Enter cat food name: ");
            string name = Console.ReadLine();
            var catFood = logic.GetCatFoodByName(name);
            DisplayProductDetails(catFood);
        }

        
        /// Prints the product details in a formatted way.       
        static void DisplayProductDetails(Product product)
        {
            if (product != null) Console.WriteLine(JsonSerializer.Serialize(product, new JsonSerializerOptions { WriteIndented = true }));
            else Console.WriteLine("Product not found.");
        }

        
        /// Displays a list of products that are currently in stock.      
        static void DisplayInStockProducts(ProductLogic logic)
        {
            var products = logic.GetOnlyInStockProducts();
            if (products.Any())
            {
                Console.WriteLine("In-stock products:");
                foreach (var product in products) Console.WriteLine(product.Name);
            }
            else Console.WriteLine("No products in stock.");
        }

        
        /// Displays the total value of all items in the inventory.      
        static void DisplayTotalInventoryValue(ProductLogic logic)
        {
            Console.WriteLine($"Total inventory value: {logic.GetTotalPriceOfInventory():C}");
        }
    }
}
