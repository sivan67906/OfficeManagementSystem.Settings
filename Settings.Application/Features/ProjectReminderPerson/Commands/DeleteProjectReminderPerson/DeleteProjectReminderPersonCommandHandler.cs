using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.ProjectReminderPersons.Commands.DeleteProjectReminderPerson;

internal class DeleteProjectReminderPersonCommandHandler : IRequestHandler<DeleteProjectReminderPersonCommand>
{
    private readonly IGenericRepository<ProjectReminderPerson> _projectReminderPersonRepository;

    public DeleteProjectReminderPersonCommandHandler(
        IGenericRepository<ProjectReminderPerson> projectReminderPersonRepository) =>
        _projectReminderPersonRepository = projectReminderPersonRepository;
    public async System.Threading.Tasks.Task Handle(DeleteProjectReminderPersonCommand request, CancellationToken cancellationToken)
    {
        await _projectReminderPersonRepository.DeleteAsync(request.Id);
    }
}
























