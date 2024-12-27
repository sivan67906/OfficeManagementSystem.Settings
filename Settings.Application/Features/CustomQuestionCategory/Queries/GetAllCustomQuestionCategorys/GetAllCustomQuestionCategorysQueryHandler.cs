using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.CustomQuestionCategories.Queries.GetAllCustomQuestionCategories;

internal class GetAllCustomQuestionCategoriesQueryHandler : IRequestHandler<GetAllCustomQuestionCategoriesQuery, IEnumerable<CustomQuestionCategoryDTO>>
{
    private readonly IGenericRepository<CustomQuestionCategory> _customQuestionCategoryRepository;
    private readonly IGenericRepository<ProjectReminderPerson> _projectReminderPersonRepository;

    public GetAllCustomQuestionCategoriesQueryHandler(
        IGenericRepository<CustomQuestionCategory> customQuestionCategoryRepository,
        IGenericRepository<ProjectReminderPerson> projectReminderPersonRepository)
    {
        _customQuestionCategoryRepository = customQuestionCategoryRepository;
        _projectReminderPersonRepository = projectReminderPersonRepository;
    }

    public async Task<IEnumerable<CustomQuestionCategoryDTO>> Handle(GetAllCustomQuestionCategoriesQuery request, CancellationToken cancellationToken)
    {
        var customQuestionCategories = await _customQuestionCategoryRepository.GetAllAsync();
        var projectReminderPersons = await _projectReminderPersonRepository.GetAllAsync();
        var projectReminderPersonsList = projectReminderPersons.Select(x => new ProjectReminderPersonDTO
        {
            Id = x.Id,
            Name = x.Name,
        }).ToList();

        var customQuestionCategoryList = customQuestionCategories.Select(x => new CustomQuestionCategoryDTO
        {
            Id = x.Id,
            CQCategoryCode = x.CQCategoryCode,
            CQCategoryName = x.CQCategoryName
        }).ToList();

        return customQuestionCategoryList;
    }
}
























