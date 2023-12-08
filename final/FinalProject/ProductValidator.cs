// ProductValidator class (Abstraction)
abstract class ProductValidator
{
    public abstract bool ValidateName(string name);
    public abstract bool ValidatePrice(decimal price);
    public abstract bool ValidateQuantity(int quantity);
}