class UserInterface
{
    public void DisplayMenu()
    {
        Console.WriteLine("1. Add Product");
        Console.WriteLine("2. Remove Product");
        Console.WriteLine("3. Update Product");
        Console.WriteLine("4. List All Products");
        Console.WriteLine("5. Exit");
    }

    public int GetUserInput()
    {
        Console.Write("Enter your choice: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayProductDetails(Product product)
    {
    
    }
}