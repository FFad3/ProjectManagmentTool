using PMT.Domain.Common;
using PMT.Domain.ValueObjects;

namespace PMT.Domain.Project
{
    public sealed class ProjectUser : BaseEntity<Guid>
    {
        public ProjectUser()
        {
        }

        public ProjectUser(Guid userId, UserName userName) : base(userId)
        {
            this.UserName = userName;
        }

        public UserName UserName { get; private set; }
    }
}