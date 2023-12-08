// BasicProductValidator class (Concrete class)
class BasicProductValidator : ProductValidator
{
    public override bool ValidateName(string name)
    {
        return !string.IsNullOrEmpty(name);
    }

    public override bool ValidatePrice(decimal price)
    {
        return price >= 0;
    }

    public override bool ValidateQuantity(int quantity)
    {
        return quantity >= 0;
    }
}