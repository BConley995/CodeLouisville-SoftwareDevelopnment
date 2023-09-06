namespace Software1_Knowledge_Check2
{
    class Program
    {
        static List<Cat> CatRecords = new List<Cat>();
        static List<Dog> DogRecords = new List<Dog>();
        static List<Other> OtherRecords = new List<Other>();

        static void Main(string[] args)
        {
            int selection;
            do
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Cat");
                Console.WriteLine("2. Add Dog");
                Console.WriteLine("3. Add Other Animal");
                Console.WriteLine("4. View Cat Records");
                Console.WriteLine("5. View Dog Records");
                Console.WriteLine("6. View Other Animal Records");
                Console.WriteLine("7. Exit");

                selection = int.Parse(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        AddCat();
                        break;
                    case 2:
                        AddDog();
                        break;
                    case 3:
                        AddOther();
                        break;
                    case 4:
                        DisplayRecords(CatRecords);
                        break;
                    case 5:
                        DisplayRecords(DogRecords);
                        break;
                    case 6:
                        DisplayRecords(OtherRecords);
                        break;
                }

            } while (selection != 7);
        }

        static void AddCat()
        {
            var cat = new Cat();
            Console.WriteLine("Enter the name of the cat: ");
            cat.Name = Console.ReadLine();
            Console.WriteLine("Enter the color of the cat: ");
            cat.Color = Console.ReadLine();
            CatRecords.Add(cat);
        }

        static void AddDog()
        {
            var dog = new Dog();
            Console.WriteLine("Enter the name of the dog: ");
            dog.Name = Console.ReadLine();
            Console.WriteLine("Enter the breed of the dog: ");
            dog.Breed = Console.ReadLine();
            DogRecords.Add(dog);
        }

        static void AddOther()
        {
            var other = new Other();
            Console.WriteLine("Enter the name of the animal: ");
            other.Name = Console.ReadLine();
            Console.WriteLine("Enter the type of the animal (e.g., reptile, bird): ");
            other.Type = Console.ReadLine();
            OtherRecords.Add(other);
        }

        static void DisplayRecords<T>(List<T> records) where T : Animal
        {
            Console.WriteLine("\nList of Records:");
            foreach (var record in records)
            {
                Console.WriteLine(record.Name);
                if (record is Cat cat)
                    Console.WriteLine($"Color: {cat.Color}");
                else if (record is Dog dog)
                    Console.WriteLine($"Breed: {dog.Breed}");
                else if (record is Other other)
                    Console.WriteLine($"Type: {other.Type}");
            }
            Console.WriteLine();
        }
    }
}