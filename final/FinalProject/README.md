Here's a step-by-step guide and explanation of the key components of the Inventory Management System

Classes:

    1- Product Class: Represents a product with properties like ProductID, Name, Price, QuantityOnHand, and Category. It also has methods for displaying product details, updating price and quantity, saving to and loading from a file.

    2- InventoryManager Class: Manages a list of products. It allows adding, removing, and listing products. It also has a Products property to access and modify the list.

    3- Category Class: A simple placeholder class for demonstrating the principle of abstraction. It doesn't have much functionality in this example.

    4- Logger Class: Provides methods for logging information and errors.

    5- UserInterface Class: Handles user interactions by displaying a menu, taking user input, and showing product details.

    6- FileManager Class: Manages saving and loading product data to and from a text file.

    7- DiscountedProduct Class: Extends the Product class and adds discount-related functionality.

    8- ProductValidator Class: An abstract class providing a basic structure for product validation.

    9- BasicProductValidator Class: Extends the ProductValidator class and provides specific validation logic for product details.

    10- Program Class: The main entry point of the program

Menu Options:

    Add Product (Option 1): Allows the user to input details for a new product and adds it to the inventory.

    Remove Product (Option 2): Prompts the user to enter a ProductID and removes the corresponding product from the inventory.

    List All Products (Option 3): Displays details for all products in the inventory.

    Exit (Option 4): Saves the current inventory to a file using the SaveToFile method of the FileManager and exits the program.

Product Validation:

    The program includes a basic product validation mechanism using the ProductValidator and BasicProductValidator classes.

    The AddProduct method checks if the product details are valid before adding it to the inventory.

Discounted Products:

    The system demonstrates inheritance by introducing a DiscountedProduct class that extends the Product class. It adds discount-related functionality.

File Management:

    The FileManager class handles saving and loading product data to/from a text file (InventoryData.txt). The data is stored in a comma-separated format.

Logging:

    The Logger class provides basic logging capabilities. In a real-world scenario, more advanced logging mechanisms might be used.

User Interface:

    The UserInterface class manages user interactions by displaying a menu, taking user input, and showing product details.

Execution:

    Run the program, and it will guide you through the menu options. Input values as prompted, and you'll be able to manage the inventory.

Usage:

    The program starts in the Main method where instances of the InventoryManager, UserInterface, and FileManager classes are created.

    The initial list of products is loaded from a file using the LoadFromFile method of the FileManager.

    The InventoryManager is then initialized with the loaded products.

    A loop is implemented to continuously display the menu, take user input, and perform corresponding actions until the user chooses to exit.