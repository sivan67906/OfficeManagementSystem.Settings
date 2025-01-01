using MediatR;

namespace Settings.Application.Features.ProjectReminderPersons.Commands.DeleteProjectReminderPerson
{
    public class DeleteProjectReminderPersonCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
























