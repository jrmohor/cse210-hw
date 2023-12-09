using System.IO;
class FileManager // FileManager class
{
    private string filePath = "InventoryData.txt";

    public void SaveToFile(List<Product> products)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var product in products)
                {
                    product.SaveToFile(writer);
                }
            }
            Console.WriteLine("Data saved to file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving to file: {ex.Message}");
        }
    }

    public List<Product> LoadFromFile()
    {
        List<Product> loadedProducts = new List<Product>();
        try
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        loadedProducts.Add(Product.LoadFromFile(line));
                    }
                }
                Console.WriteLine("Data loaded from file.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading from file: {ex.Message}");
        }
        return loadedProducts;
    }
}