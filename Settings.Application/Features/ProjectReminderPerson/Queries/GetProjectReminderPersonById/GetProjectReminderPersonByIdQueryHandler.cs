using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.ProjectReminderPersons.Queries.GetProjectReminderPersonById;

internal class GetProjectReminderPersonByIdQueryHandler : IRequestHandler<GetProjectReminderPersonByIdQuery, ProjectReminderPersonDTO>
{
    private readonly IGenericRepository<ProjectReminderPerson> _projectReminderPersonRepository;

    public GetProjectReminderPersonByIdQueryHandler(
        IGenericRepository<ProjectReminderPerson> projectReminderPersonRepository) =>
        _projectReminderPersonRepository = projectReminderPersonRepository;

    public async Task<ProjectReminderPersonDTO> Handle(GetProjectReminderPersonByIdQuery request, CancellationToken cancellationToken)
    {
        var projectReminderPerson = await _projectReminderPersonRepository.GetByIdAsync(request.Id);
        if (projectReminderPerson == null) return null;
        return new ProjectReminderPersonDTO
        {
            Id = projectReminderPerson.Id,
            Name = projectReminderPerson.Name
        };
    }
}
























