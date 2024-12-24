using MediatR;

namespace Settings.Application.Features.ProjectReminderPersons.Commands.DeleteProjectReminderPerson
{
    public class DeleteProjectReminderPersonCommand : IRequest
    {
        public int Id { get; set; }
    }
}
























