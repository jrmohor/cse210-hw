class Product
{
    public int ProductID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int QuantityOnHand { get; set; }
    public string Category { get; set; }

    public void GetDetails()
    {
        Console.WriteLine($"ProductID: {ProductID}, Name: {Name}, Price: {Price:C}, Quantity: {QuantityOnHand}, Category: {Category}");
    }

    public void UpdatePrice(decimal newPrice)
    {
        Price = newPrice;
        Console.WriteLine("Price updated successfully.");
    }

    public void UpdateQuantity(int newQuantity)
    {
        QuantityOnHand = newQuantity;
        Console.WriteLine("Quantity updated successfully.");
    }

     public void SaveToFile(StreamWriter writer)
    {
        writer.WriteLine($"{ProductID},{Name},{Price},{QuantityOnHand},{Category}");
    }
    
    public static Product LoadFromFile(string line)
    {
        string[] data = line.Split(',');
        return new Product
        {
            ProductID = int.Parse(data[0]),
            Name = data[1],
            Price = decimal.Parse(data[2]),
            QuantityOnHand = int.Parse(data[3]),
            Category = data[4]
        };
    }
}