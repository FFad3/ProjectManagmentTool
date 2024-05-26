using PMT.Domain.Common.Interfaces;

namespace PMT.Domain.Common
{
    public class BaseAggregateRoot<TId> : BaseEntity<TId>, IAggregateRoot
    {
        private List<IDomainEvent> _domainEvents = new();

        protected BaseAggregateRoot() : base()
        {
        }

        public BaseAggregateRoot(TId id) : base(id)
        {
        }

        public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

        public void AddDomainEvent(IDomainEvent domainEvent)
            => _domainEvents.Add(domainEvent);

        public void ClearDomainEvents()
            => _domainEvents.Clear();
    }
}