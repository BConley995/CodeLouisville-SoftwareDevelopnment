# PetStore Part 11

## Introduction
This project is a continuation of the PetStore project, where the goal was to convert the existing application into an API. This transformation enables the project to be more modular, scalable, and accessible over the web. The following README provides an overview of the steps followed to achieve this goal.

## Goals
* Convert the PetStore application into an API.
* Replace the console input with web endpoints.
* Test the API's functionality.

## Instructions Followed

### 1. Converting the Project
For this step, the primary focus was on the main PetStore project. The aim was to transform the project into an API structure.
- **Tutorial Followed**: [Build ASP.NET Core Web API Project](https://dotnettutorials.net/lesson/build-asp-net-core-web-api-project/)

### 2. Adding WebHost
In this stage, the program class was replaced, and it was ensured that only necessary components to run the API remained. The original services were carefully saved before making any deletions.
- **Tutorial Followed**: [Adding Web Host Builder](https://dotnettutorials.net/lesson/adding-web-host-builder/)

### 3. Adding Startup File
The Startup class was introduced to reintegrate the services that were originally part of the program file. This configuration allowed for seamless integration and initializations when the API is started.
- **Tutorial Followed**: [Configuring Startup Class](https://dotnettutorials.net/lesson/configuring-startup-class/)

### 4. Adding a Controller
A controller was added to mirror and replace the functionality of the program file. Initially, only GET methods were set up, specifically one to retrieve a product and another for an order. As an extended task, POST methods were also incorporated to add products and orders.
- **Tutorial Followed**: [Adding Controller in ASP.NET Core](https://dotnettutorials.net/lesson/adding-controller-in-asp-net-core/)

## Testing

On running the application, it was designed to open in a web browser. For routing, the setup was such that the controller, method, and ID would define the endpoint. An example route used was: `https://localhost:62235/product/getorder/1`.

To further test POST methods, external tools like Postman can be utilized to interact with the application, simulate requests, and inspect responses.

## Wrapping up

This exercise was an enriching experience in understanding the nuances of converting a traditional application into a web API. It underscored the importance of modular design and provided hands-on experience with ASP.NET Core's features.