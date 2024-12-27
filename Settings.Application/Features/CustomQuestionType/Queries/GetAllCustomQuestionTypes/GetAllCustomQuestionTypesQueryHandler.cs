using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.CustomQuestionTypes.Queries.GetAllCustomQuestionTypes;

internal class GetAllCustomQuestionTypesQueryHandler : IRequestHandler<GetAllCustomQuestionTypesQuery, IEnumerable<CustomQuestionTypeDTO>>
{
    private readonly IGenericRepository<CustomQuestionType> _customQuestionTypeRepository;
    private readonly IGenericRepository<ProjectReminderPerson> _projectReminderPersonRepository;

    public GetAllCustomQuestionTypesQueryHandler(
        IGenericRepository<CustomQuestionType> customQuestionTypeRepository,
        IGenericRepository<ProjectReminderPerson> projectReminderPersonRepository)
    {
        _customQuestionTypeRepository = customQuestionTypeRepository;
        _projectReminderPersonRepository = projectReminderPersonRepository;
    }

    public async Task<IEnumerable<CustomQuestionTypeDTO>> Handle(GetAllCustomQuestionTypesQuery request, CancellationToken cancellationToken)
    {
        var customQuestionTypes = await _customQuestionTypeRepository.GetAllAsync();
        var customQuestionTypeList = customQuestionTypes.Select(x => new CustomQuestionTypeDTO
        {
            Id = x.Id,
            CQTypeCode = x.CQTypeCode,
            CQTypeName = x.CQTypeName
        }).ToList();

        return customQuestionTypeList;
    }
}
























