using PMT.Domain.Common.Interfaces;

namespace PMT.Domain.Common
{
    /// <summary>
    /// Base type for all Entities with tracked state using given Id
    /// </summary>
    public abstract class BaseEntity<Tid> : IEntity<Tid>
    {
        public Tid Id { get; protected set; }

        protected BaseEntity()
        {
        }

        protected BaseEntity(Tid id)
        {
            this.Id = id;
        }
    }
}