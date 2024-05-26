using PMT.Domain.Common;
using PMT.Domain.ValueObjects;

namespace PMT.Domain.Project
{
    public sealed class Project : BaseAggregateRoot<EntityId>
    {
        public ProjectName Name { get; private set; }
        //Sprints
        private HashSet<ProjectSprint> _projectSprints = new();

        public IReadOnlyCollection<ProjectSprint> ProjectSprints => _projectSprints.ToList().AsReadOnly();

        //Users
        public ProjectUser Owner { get; private set; }

        private HashSet<ProjectUser> _projectUsers = new();

        public IReadOnlyCollection<ProjectUser> ProjectUsers => _projectUsers.ToList().AsReadOnly();
    }
}