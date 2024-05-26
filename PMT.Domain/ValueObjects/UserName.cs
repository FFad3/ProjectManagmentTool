using PMT.Domain.Common;

namespace PMT.Domain.ValueObjects
{
    public record UserName
    {
        public const int MaxLenght = 20;
        public const int MinLenght = 3;

        public string Value { get; }

        public UserName(string value)
        {
            if (string.IsNullOrEmpty(value) || value.Length is > MaxLenght or < MinLenght)
            {
                throw new BuisnessRuleValidationException<UserName>($"Lenght muust be between {MinLenght} - {MaxLenght} characters");
            }
            Value = value;
        }

        public static implicit operator string(UserName data) => data.Value;

        public static implicit operator UserName(string value) => new(value);
    }
}