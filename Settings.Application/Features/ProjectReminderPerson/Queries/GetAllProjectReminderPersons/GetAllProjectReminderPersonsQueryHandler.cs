using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.ProjectReminderPersons.Queries.GetAllProjectReminderPersons;

internal class GetAllProjectReminderPersonsQueryHandler : IRequestHandler<GetAllProjectReminderPersonsQuery, IEnumerable<ProjectReminderPersonDTO>>
{
    private readonly IGenericRepository<ProjectReminderPerson> _projectReminderPersonRepository;

    public GetAllProjectReminderPersonsQueryHandler(
        IGenericRepository<ProjectReminderPerson> projectReminderPersonRepository) =>
        _projectReminderPersonRepository = projectReminderPersonRepository;

    public async Task<IEnumerable<ProjectReminderPersonDTO>> Handle(GetAllProjectReminderPersonsQuery request, CancellationToken cancellationToken)
    {
        var companies = await _projectReminderPersonRepository.GetAllAsync();

        var projectReminderPersonList = companies.Select(x => new ProjectReminderPersonDTO
        {
            Id = x.Id,
            Name = x.Name
        }).ToList();

        return projectReminderPersonList;
    }
}
























