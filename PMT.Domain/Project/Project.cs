using PMT.Domain.Common;
using PMT.Domain.ValueObjects;

namespace PMT.Domain.Project
{
    //TODO: DOmain description
    //------Project--------
    //Creator of project is an owner
    //Owner can edit project data, add/remove/update sprint, add/remove participants
    //Participant can create/remove/update tasks in project
    //-------Sprint---------
    //Only project owner can create a sprint
    //All participants can add/remove tasks from sprint (or change state)*
    //Sprint can have X max number of tasks
    //Sprint duration is from Start - End date
    //All unfinished tasks can be detatched from a sprint -> back to project task pool
    //--------Task----------
    //Participant can be assigned to task - max 1
    //Participant can create/edit/update task
    //participant can create commment - edit/remove only for creator and project owner
    //--------ApplicaitonUser--------(Potentially out of domain scope)*[Resource based permission like linux resource_id,[read,write,edit]]???
    //Has one of 3 roles:
    //Project manager - can create and manage projects
    //Developer - can be a participant in project 
    //Admin - can manage permissions
    public sealed class Project : BaseAggregateRoot<EntityId>
    {
        //We can create new project
        //Creater of project is an owner
        //Owner can edit all project items
        //Owner can add other participants
        //Participant can add new tasks to project
        //Owner can assign tasks to Sprint
        //Sprint is has start - end date

        public ProjectName Name { get; private set; }

        //Sprints
        private HashSet<ProjectSprint> _projectSprints = new();

        public IReadOnlyCollection<ProjectSprint> ProjectSprints => _projectSprints.ToList().AsReadOnly();

        //Users
        public Guid OwnerId { get; private set; }

        private HashSet<ProjectUser> _projectUsers = new();

        public IReadOnlyCollection<ProjectUser> ProjectUsers => _projectUsers.ToList().AsReadOnly();

        private Project()
        {
        }

        public Project(
            EntityId entityId,
            ProjectName projectName,
            Guid ownerId,
            IEnumerable<ProjectSprint> projectSprints,
            IEnumerable<ProjectUser> projectUsers) : base(entityId)
        {
        }

        public ProjectUser GetOwner()
            => _projectUsers.FirstOrDefault(u => u.Id == OwnerId) ?? throw new BuisnessRuleValidationException<Project>("Owner does not exists");
    }
}