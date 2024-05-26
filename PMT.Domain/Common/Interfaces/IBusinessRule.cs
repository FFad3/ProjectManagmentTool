namespace PMT.Domain.Common.Interfaces
{
    public interface IBusinessRule
    {
        bool IsValid();

        string Message { get; }
    }
}