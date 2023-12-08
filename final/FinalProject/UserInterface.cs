class UserInterface
{
    public void DisplayMenu()
    {
        Console.WriteLine("1. Add Product");
        Console.WriteLine("2. Remove Product");
        Console.WriteLine("3. List All Products");
        Console.WriteLine("4. Exit");
    }

    public int GetUserInput()
    {
        Console.Write("Enter your choice: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayProductDetails(Product product)
    {
        product.GetDetails();
    }
}
