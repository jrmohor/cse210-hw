using System;

class Program
{
    static void Main(string[] args)
    {
        InventoryManager inventoryManager = new InventoryManager();
        UserInterface userInterface = new UserInterface();
        FileManager fileManager = new FileManager();

        List<Product> initialProducts = fileManager.LoadFromFile();
        inventoryManager = new InventoryManager { Products = initialProducts };

        while (true)
        {
            userInterface.DisplayMenu();
            int choice = userInterface.GetUserInput();

            switch (choice)
            {
                case 1:
                    AddProduct(inventoryManager);
                    break;
                case 2:
                    RemoveProduct(inventoryManager);
                    break;
                case 3:
                    ListAllProducts(inventoryManager);
                    break;
                case 4:
                    fileManager.SaveToFile(inventoryManager.Products);
                    Console.WriteLine("Exiting the program.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddProduct(InventoryManager inventoryManager)
    {
        Console.WriteLine("Enter product details:");
        Product product = new Product();
        Console.Write("ProductID: ");
        product.ProductID = Convert.ToInt32(Console.ReadLine());
        Console.Write("Name: ");
        product.Name = Console.ReadLine();
        Console.Write("Price: ");
        product.Price = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Quantity: ");
        product.QuantityOnHand = Convert.ToInt32(Console.ReadLine());
        Console.Write("Category: ");
        product.Category = Console.ReadLine();

        BasicProductValidator validator = new BasicProductValidator();
        if (validator.ValidateName(product.Name) && validator.ValidatePrice(product.Price) && validator.ValidateQuantity(product.QuantityOnHand))
        {
            inventoryManager.AddProduct(product);
        }
        else
        {
            Console.WriteLine("Invalid product details. Please check and try again.");
        }
    }
    static void RemoveProduct(InventoryManager inventoryManager)
    {
        Console.Write("Enter the ProductID to remove: ");
        int productID = Convert.ToInt32(Console.ReadLine());
        inventoryManager.RemoveProduct(productID);
    }

    static void ListAllProducts(InventoryManager inventoryManager)
    {
        inventoryManager.ListAllProducts();
    } 
}