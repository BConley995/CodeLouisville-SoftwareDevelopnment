using System;
using System.Text.Json;
using Software1ClassExercise4_PetStorePart3;

namespace Software1ClassExercise4_PetStorePart3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductLogic productLogic = new ProductLogic();

            PrintMenu();

            string userInput = Console.ReadLine();

            while (userInput.ToLower() != "exit")
            {
                switch (userInput)
                {
                    case "1":
                        AddCatFood(productLogic);
                        break;
                    case "2":
                        AddDryCatFood(productLogic);
                        break;
                    case "3":
                        AddDogLeash(productLogic);
                        break;
                    case "4":
                        ViewDogLeash(productLogic);
                        break;
                    case "5":
                        ViewCatFood(productLogic);
                        break;
                    case "6":
                        ViewInStockProducts(productLogic);
                        break;
                }

                PrintMenu();

                userInput = Console.ReadLine();

            }
        

        static void PrintMenu()
        {
            Console.WriteLine("Press 1 to add a wet cat food product");
            Console.WriteLine("Press 2 to add a dry cat food product");
            Console.WriteLine("Press 3 to add a dog leash product");
            Console.WriteLine("Press 4 to view a dog leash by name");
            Console.WriteLine("Press 5 to view cat food by name");
            Console.WriteLine("Press 6 to view In Stock Items");
            Console.WriteLine("Type 'exit' to quit");
        }
    }

        static void AddCatFood(ProductLogic productLogic)
        {
            CatFood catFood = new CatFood();

            Console.Write("Enter product name: ");
            catFood.Name = Console.ReadLine();

            Console.Write("Enter product price: ");
            catFood.Price = decimal.Parse(Console.ReadLine());

            Console.Write("Enter product quantity: ");
            catFood.Quantity = int.Parse(Console.ReadLine());

            Console.Write("Enter product description: ");
            catFood.Description = Console.ReadLine();

            Console.Write("Enter cat food weight in pounds: ");
            catFood.WeightPounds = double.Parse(Console.ReadLine());

            Console.Write("Is this kitten food? (yes/no): ");
            catFood.KittenFood = Console.ReadLine().ToLower() == "yes";

            productLogic.AddProduct(catFood);
            Console.WriteLine("The cat food product was added successfully!");
        }

        static void AddDryCatFood(ProductLogic productLogic)
        {
            DryCatFood dryCatFood = new DryCatFood();

            Console.Write("Enter product name: ");
            dryCatFood.Name = Console.ReadLine();

            Console.Write("Enter product price: ");
            dryCatFood.Price = decimal.Parse(Console.ReadLine());

            Console.Write("Enter product quantity: ");
            dryCatFood.Quantity = int.Parse(Console.ReadLine());

            Console.Write("Enter product description: ");
            dryCatFood.Description = Console.ReadLine();

            Console.Write("Enter dry cat food weight in pounds: ");
            dryCatFood.WeightPounds = double.Parse(Console.ReadLine());

            Console.Write("Is this kitten food? (yes/no): ");
            dryCatFood.KittenFood = Console.ReadLine().ToLower() == "yes";

            productLogic.AddProduct(dryCatFood);
            Console.WriteLine("The dry cat food product was added successfully!");
        }


        static void AddDogLeash(ProductLogic productLogic)
        {
            DogLeash dogLeash = new DogLeash();

            Console.Write("Enter product name: ");
            dogLeash.Name = Console.ReadLine();

            Console.Write("Enter product price: ");
            dogLeash.Price = decimal.Parse(Console.ReadLine());

            Console.Write("Enter product quantity: ");
            dogLeash.Quantity = int.Parse(Console.ReadLine());

            Console.Write("Enter product description: ");
            dogLeash.Description = Console.ReadLine();

            Console.Write("Enter dog leash length in inches: ");
            dogLeash.LengthInches = int.Parse(Console.ReadLine());

            productLogic.AddProduct(dogLeash);
            Console.WriteLine("The dog leash product was added successfully!");
        }

        static void ViewDogLeash(ProductLogic productLogic)
        {
            Console.Write("Enter the name of the dog leash: ");
            string name = Console.ReadLine();

            DogLeash dogLeash = productLogic.GetDogLeashByName(name);

            if (dogLeash != null)
            {
                Console.WriteLine(JsonSerializer.Serialize(dogLeash));
            }
            else
            {
                Console.WriteLine("No dog leash with that name found");
            }
        }

        static void ViewCatFood(ProductLogic productLogic)
        {
            Console.Write("Enter the name of the cat food: ");
            string name = Console.ReadLine();

            CatFood catFood = productLogic.GetCatFoodByName(name);

            if (catFood != null)
            {
                Console.WriteLine(JsonSerializer.Serialize(catFood));
            }
            else
            {
                Console.WriteLine("No cat food with that name found");
            }
        }
        static void ViewInStockProducts(ProductLogic productLogic)
        {
            var inStockProducts = productLogic.GetOnlyInStockProducts();

            if (inStockProducts.Any())
            {
                Console.WriteLine("In-stock products:");
                foreach (var productName in inStockProducts)
                {
                    Console.WriteLine(productName);
                }
            }
            else
            {
                Console.WriteLine("No products in stock right now.");
            }
        }

    }
}
