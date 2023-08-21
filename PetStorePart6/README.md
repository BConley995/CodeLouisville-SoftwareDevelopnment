## Software 1 - Class Exercise 6

### Overview

In this exercise, the emphasis was on applying "Clean Coding" principles to refactor and enhance the readability and maintainability of the application. The goal was not just to produce functioning code, but also to ensure that the code is clear, concise, and organized.

### Achievements

1. **Duplicate Code Reduction**: Upon inspection, we identified sections of repeated code and extracted them into distinct methods to reduce redundancy and improve maintainability.
   
2. **Reorganization**: Instead of confining all functionality within the `Program.cs` file, we segregated tasks into distinct classes. We introduced the `UILogic` class to handle user interaction, thereby decluttering the main execution path.

3. **Class Comments Addition**: Leveraging the power of XML documentation, we added class, method, and property comments (`///`) to enhance understanding. This aids future developers (or even the current ones) in quickly grasping the purpose and usage of classes and methods.

4. **File & Namespace Organization**: Files were systematically organized into respective folders to provide a clearer structure to the solution. The namespaces of these files were adjusted accordingly to reflect their location in the solution's hierarchy.

5. **Interface Adoption**: In places where we found potential for decoupling, we introduced interfaces. This provides flexibility, facilitates testing, and promotes the usage of more generic code. For instance, the introduction of `IProductLogic` allows for potential different implementations in the future without changing the consuming classes.

### Reflections

On reviewing previous exercises, we recognized that we had inadvertently employed several clean coding principles, even if not explicitly stated. This exercise amplified those principles and provided a structured approach to clean coding. We encourage everyone to review and discuss their prior work in light of these principles.
