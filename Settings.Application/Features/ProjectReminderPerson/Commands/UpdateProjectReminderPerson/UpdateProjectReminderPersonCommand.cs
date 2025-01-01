using MediatR;

namespace Settings.Application.Features.ProjectReminderPersons.Commands.UpdateProjectReminderPerson;

public class UpdateProjectReminderPersonCommand : IRequest
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
}
























