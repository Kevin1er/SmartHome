using System.Text.RegularExpressions;

namespace SmartHome.Validations
{
    class EmailValidator : IValidationRule<string>
    {
        const string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
        public string Description => "Please enter a valid email.";

        public bool Validate(string _value)
        {
            if (string.IsNullOrEmpty(_value)) return false;
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(_value);
        }
    }
}
