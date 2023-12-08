class InventoryManager
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
        Console.WriteLine("Product added to the inventory.");
    }

    public List<Product> Products
    {
        get { return products; }
        set { products = value; }
    }
    public void RemoveProduct(int productID)
    {
        Product productToRemove = products.Find(p => p.ProductID == productID);
        if (productToRemove != null)
        {
            products.Remove(productToRemove);
            Console.WriteLine("Product removed from the inventory.");
        }
        else
        {
            Console.WriteLine("Product not found in the inventory.");
        }
    }

    public void ListAllProducts()
    {
        foreach (var product in products)
        {
            product.GetDetails();
        }
    }
}