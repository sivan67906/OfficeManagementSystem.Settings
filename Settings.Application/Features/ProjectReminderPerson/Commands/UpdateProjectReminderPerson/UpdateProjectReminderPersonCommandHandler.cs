using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.ProjectReminderPersons.Commands.UpdateProjectReminderPerson;

internal class UpdateProjectReminderPersonCommandHandler : IRequestHandler<UpdateProjectReminderPersonCommand>
{
    private readonly IGenericRepository<ProjectReminderPerson> _projectReminderPersonRepository;

    public UpdateProjectReminderPersonCommandHandler(
        IGenericRepository<ProjectReminderPerson> projectReminderPersonRepository) =>
        _projectReminderPersonRepository = projectReminderPersonRepository;

    public async System.Threading.Tasks.Task Handle(UpdateProjectReminderPersonCommand request, CancellationToken cancellationToken)
    {
        var projectReminderPerson = new ProjectReminderPerson
        {
            Id = request.Id,
            Name = request.Name,
            UpdatedDate = DateTime.Now
        };

        await _projectReminderPersonRepository.UpdateAsync(projectReminderPerson);
    }
}
























