# Pet Store Parto 10 

Welcome to the PetStore project! This application was developed to provide a simple yet functional management system for pet-related products. Here's an overview of what we built and the reasoning behind our choices.

## Overview

PetStore aims to simplify the process of managing pet products in a store setting. Users can add, view, and manage products via a user-friendly console application. This is a starting point and can be expanded with many other features in the future.

## Tech Stack

- **C#**: The primary programming language for our application logic.
- **.NET 6.0**: Our chosen framework, which offers a range of tools and libraries to build robust applications.
- **Entity Framework Core**: This ORM allows us to interact with our database using C# objects.
- **SQLite**: A lightweight database solution, perfect for our application's scale.

## Key Features

1. **Product Management**: Add products by inputting them in JSON format. Each product can have attributes like `ProductId`, `Name`, `Description`, and `Price`.
2. **Product Viewing**: View specific product details by entering its `ProductId`.

## Design Decisions

- **Mock Testing**: We incorporated mock testing to simulate parts of our application during testing. This ensures our logic works correctly without needing to interact with external dependencies.
- **Dependency Injection**: Used to ensure our classes remain loosely coupled. This is beneficial for testing and future scalability.
- **Database First Design**: By defining our database schema first, we ensured our data's structure was sound, and then we built our application's logic around it.
- **Console-based UI**: Given the project's scope, a console application sufficed. It's lightweight and straightforward for end-users.

## Current Known Issues
when adding test product of "{ "Products": [ {"ProductId": 2, "Name": "Dog bowl", "Description": "A thing that holds food", "Price": 8.99}, {"ProductId": 2, "Name": "Chew toy", "Description": "A thing that dogs chew", "Price": 2.89} ] }"  than viewing the product by ID, it shows as null