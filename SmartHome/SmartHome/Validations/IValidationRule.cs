namespace SmartHome.Validations
{
    public interface IValidationRule<T>
    {
        string Description { get; }
        bool Validate(T _value);
    }
}
