namespace PMT.Domain.Common.Interfaces
{
    public interface IEntity<Tid>
    {
        Tid Id { get; }
    }
}