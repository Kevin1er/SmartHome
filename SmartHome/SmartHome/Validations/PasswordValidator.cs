
namespace SmartHome.Validations
{
    class PasswordValidator : IValidationRule<string>
    {
        const int minLength = 4;
        public string Description => $"Password should at least {minLength} characters long.";
        public bool Validate(string _value) => !string.IsNullOrEmpty(_value) && _value.Length >= minLength;
    }
}
