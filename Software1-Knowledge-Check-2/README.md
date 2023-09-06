# Knowledge Check 2 - Object-Oriented Programming (OOP) in C#

## Purpose:

The purpose of this knowledge check is to assess the understanding of core OOP concepts, specifically:

1. Creation and management of classes.
2. Using inheritance to derive one class from another.
3. Implementing a user-friendly console interface.
4. Storing and retrieving object instances in lists.
5. Basic program organization and code separation for better readability.

## Overview:

In this project, we have simulated a basic animal record-keeping system. The primary classes (Animal, Cat, Dog, and Other) serve as the backbone for the system. 

- The `Animal` class serves as the base, with a property `Name` to hold the name of the animal.
- The `Cat`, `Dog`, and `Other` classes inherit from the `Animal` class. Each of these child classes introduces additional properties specific to their type:
  - `Cat` includes a `Color` property.
  - `Dog` has a `Breed` property.
  - `Other` introduces a `Type` property to specify the kind of animal (e.g., reptile, bird).

The console interface provides the user with several options:

1. Add a Cat.
2. Add a Dog.
3. Add another type of Animal.
4. View records for Cats.
5. View records for Dogs.
6. View records for Other Animals.
7. Exit the application.

## Implementation:

To ensure organization and readability:
- Separate `.cs` files have been used for each animal type.
- Switch-case statements guide the user through the options, making the program interactive.
- Generic lists (`List<T>`) serve as dynamic storage for different animal records.
