# Software1ClassExercise3_PetStorePart2

This project is a part of Software 1 class exercises and serves as a simple console application for managing a pet store inventory, specifically Cat Food and Dog Leashes.

## Description

The software allows the user to add, view, and manage different types of products for a pet store, with a focus on Cat Food and Dog Leashes. The application uses a simple command line interface for interaction.

## Installation

```bash
# Clone this repository
git clone https://github.com/<your_username>/Software1ClassExercise3_PetStorePart2.git
# Navigate into the directory
cd Software1ClassExercise3_PetStorePart2
# Open the solution file with your preferred C# IDE (e.g. Visual Studio, JetBrains Rider)
```

## Usage

Upon running the program, you'll see a text menu with the following options:

1. Add a cat food product
2. Add a dog leash product
3. View a dog leash by name
4. View cat food by name

You can add a new Cat Food or Dog Leash product by entering the required details. Similarly, you can view a product's details by entering its name.

## Project Structure

- `Product.cs` - The base product class which other product types extend. 
- `DogLeash.cs` - Represents a specific type of product, Dog Leash.
- `CatFood.cs` - Represents a specific type of product, Cat Food.
- `ProductLogic.cs` - Contains the logic for adding and retrieving products. 
- `Program.cs` - The main entry point of the program. Handles the user interface.

## License

[MIT](https://choosealicense.com/licenses/mit/)

## Contact

- Bryan.Conley@BryanConleyDesigns.com
- Project Link: https://github.com/BConley995/Software1ClassExercise3_PetStorePart2
