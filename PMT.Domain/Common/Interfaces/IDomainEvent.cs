using MediatR;

namespace PMT.Domain.Common.Interfaces
{
    public interface IDomainEvent : INotification
    {
        Guid Id { get; }
        DateTimeOffset DateOccurred { get; }
    }
}