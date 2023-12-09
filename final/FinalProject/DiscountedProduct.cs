// DiscountedProduct class (Inheritance)
class DiscountedProduct : Product
{
    public decimal Discount { get; set; }

    public void ApplyDiscount()
    {
        Price -= Discount;
        Console.WriteLine("Discount applied successfully.");
    }

    public decimal GetDiscountedPrice()
    {
        return Price - Discount;
    }
}