namespace PMT.Domain.Common
{
    public record EntityId
    {
        public string Value { get; }

        public EntityId(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new BuisnessRuleValidationException<EntityId>("Cannot be null or empty string");

            var parts = value.Split('_');

            if (parts.Length == 2 || string.IsNullOrEmpty(parts[0]) || string.IsNullOrEmpty(parts[1]))
                throw new BuisnessRuleValidationException<EntityId>("Invalid pattern");

            Value = value;
        }

        public static implicit operator string(EntityId data) => data.Value;

        public static implicit operator EntityId(string value) => new(value);

        public static EntityId Create<T>() => new($"{typeof(T)}_{Guid.NewGuid()}");
    }
}