abstract class ProductValidator // ProductValidator class (Abstraction)
{
    public abstract bool ValidateName(string name);
    public abstract bool ValidatePrice(decimal price);
    public abstract bool ValidateQuantity(int quantity);
}