using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.IsToggleTypes.Queries.GetAllIsToggleTypes;

internal class GetAllIsToggleTypesQueryHandler : IRequestHandler<GetAllIsToggleTypesQuery, IEnumerable<IsToggleTypeDTO>>
{
    private readonly IGenericRepository<IsToggleType> _isToggleTypeRepository;
    private readonly IGenericRepository<ProjectReminderPerson> _projectReminderPersonRepository;

    public GetAllIsToggleTypesQueryHandler(
        IGenericRepository<IsToggleType> isToggleTypeRepository,
        IGenericRepository<ProjectReminderPerson> projectReminderPersonRepository)
    {
        _isToggleTypeRepository = isToggleTypeRepository;
        _projectReminderPersonRepository = projectReminderPersonRepository;
    }

    public async Task<IEnumerable<IsToggleTypeDTO>> Handle(GetAllIsToggleTypesQuery request, CancellationToken cancellationToken)
    {
        var isToggleTypes = await _isToggleTypeRepository.GetAllAsync();
        var isToggleTypeList = isToggleTypes.Select(x => new IsToggleTypeDTO
        {
            Id = x.Id,
            CQTypeCode = x.CQTypeCode,
            CQTypeName = x.CQTypeName
        }).ToList();

        return isToggleTypeList;
    }
}




























