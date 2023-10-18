# Pet Store Part 12

## Dependency Injection in .NET Core Console Application

This exercise integrated the Dependency Injection (DI) pattern into a .NET Core Console application using the `Microsoft.Extensions.Hosting` package. 

## Steps Taken

1. **Installed Dependency Injection Package**:
   The `Microsoft.Extensions.Hosting` NuGet package was added to the project.

2. **Setup of Service Collection**:
   A method named `CreateServiceCollection` was created. This method configures and builds services and returns an `IServiceProvider`.

3. **Service Registration**:
   Inside the `CreateServiceCollection` method, `ProductLogic` was registered as a transient service. This ensures that a new instance of `ProductLogic` is created each time it's requested from the service provider.

4. **Replaced Direct Instantiation**:
   The direct instantiation of `ProductLogic` using the `new` keyword was replaced by retrieving the instance from the service provider.

## Reasons for Implementation

**1. Decoupling of Components**:
   Dependency injection aids in achieving a separation of concerns. Injecting dependencies ensures components are less reliant on concrete implementations.

**2. Improved Testability**:
   Dependency injection facilitates the replacement of real implementations with mock objects, streamlining unit testing.

**3. Centralized Service Configuration**:
   Registering all services in one central location simplifies the management and modification of services.

**4. Lifecycle Management**:
   The DI container handles the lifecycle of the services. For this project, the transient lifecycle was chosen, but other options like singleton and scoped are available.
