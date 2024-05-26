namespace PMT.Domain.Common.Interfaces
{
    public interface IBusinessRule
    {
        bool IsFailed();

        string Message { get; }
    }
}