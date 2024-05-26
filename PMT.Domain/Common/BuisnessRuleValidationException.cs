namespace PMT.Domain.Common
{
    public class BuisnessRuleValidationException<T> : Exception
    {
        public string TypeName { get; }

        public BuisnessRuleValidationException(string? message) : base($"{typeof(T).Name} - {message}")
        {
            TypeName = typeof(T).Name;
        }
    }
}