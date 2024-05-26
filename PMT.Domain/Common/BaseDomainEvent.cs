using MediatR;
using PMT.Domain.Common.Interfaces;

namespace PMT.Domain.Common
{
    public abstract record BaseDomainEvent : IDomainEvent
    {
        public Guid Id { get; protected set; }
        public DateTimeOffset DateOccurred { get; protected set; }
    }
}