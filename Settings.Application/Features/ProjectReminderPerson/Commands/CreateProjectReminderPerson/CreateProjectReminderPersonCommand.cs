using MediatR;

namespace Settings.Application.Features.ProjectReminderPersons.Commands.CreateProjectReminderPerson;

public class CreateProjectReminderPersonCommand : IRequest
{
    public string? Name { get; set; }
}
























