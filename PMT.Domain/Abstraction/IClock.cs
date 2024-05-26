namespace PMT.Domain.Abstraction
{
    public interface IClock
    {
        DateTime CurrentDateTime();
        DateTimeOffset CurrentOffset();
    }
}