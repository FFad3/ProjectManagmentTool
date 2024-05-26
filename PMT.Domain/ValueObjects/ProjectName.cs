using PMT.Domain.Common;

namespace PMT.Domain.ValueObjects
{
    public record ProjectName
    {
        public const int MaxLenght = 40;
        public const int MinLenght = 3;

        public string Value { get; }

        public ProjectName(string value)
        {
            if (string.IsNullOrEmpty(value) || value.Length is > MaxLenght or < MinLenght)
            {
                throw new BuisnessRuleValidationException<UserName>($"Lenght muust be between {MinLenght} - {MaxLenght} characters");
            }
            Value = value;
        }

        public static implicit operator string(ProjectName data) => data.Value;

        public static implicit operator ProjectName(string value) => new(value);
    }
}