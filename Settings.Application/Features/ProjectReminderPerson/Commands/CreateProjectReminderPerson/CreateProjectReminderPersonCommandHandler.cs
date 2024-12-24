using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.ProjectReminderPersons.Commands.CreateProjectReminderPerson;

internal class CreateProjectReminderPersonCommandHandler(
    IGenericRepository<ProjectReminderPerson> projectReminderPersonRepository) : IRequestHandler<CreateProjectReminderPersonCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateProjectReminderPersonCommand request, CancellationToken cancellationToken)
    {
        var projectReminderPerson = new ProjectReminderPerson
        {
            Name = request.Name,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await projectReminderPersonRepository.CreateAsync(projectReminderPerson);
    }
}
























