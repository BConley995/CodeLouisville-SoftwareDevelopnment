# Pet Store Management System - Part 7

A console-based application to manage the inventory and operations of a pet store.

## Overview

This project is a demonstration of advanced C# principles, focusing on Dependency Injection (DI) and loose coupling between components. With the use of `Microsoft.Extensions.DependencyInjection`, the project achieves a modular design, allowing easy adjustments and improved testability.

## Features

1. **Product Management**:
    - Add different types of products: wet cat food, dry cat food, and dog leashes.
    - View details of specific products based on their names.
    - Display a list of in-stock products.
    - Calculate and display the total value of in-stock inventory.

2. **Dependency Injection (DI)**:
    - Use of `Microsoft.Extensions.DependencyInjection` to manage dependencies.
    - Promotes loose coupling by binding to interfaces (`IProductLogic`) rather than concrete implementations.
    - Centralized service registration, enabling quick modifications to the service lifecycle and implementation.

3. **Enhanced Testability**:
    - Due to the DI pattern, components like `UILogic` can be easily tested in isolation by injecting mock implementations of dependencies.

4. **Modularity**:
    - The project is structured to allow easy expansion. For instance, a new logic implementation can be seamlessly integrated by adhering to the `IProductLogic` interface.