using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Languages.Queries.GetAllLanguages;

internal class GetAllLanguagesQueryHandler : IRequestHandler<GetAllLanguagesQuery, IEnumerable<LanguageDTO>>
{
    private readonly IGenericRepository<Language> _languageRepository;

    public GetAllLanguagesQueryHandler(
        IGenericRepository<Language> languageRepository)
    {
        _languageRepository = languageRepository;
    }

    public async Task<IEnumerable<LanguageDTO>> Handle(GetAllLanguagesQuery request, CancellationToken cancellationToken)
    {
        var languages = await _languageRepository.GetAllAsync();
        var languageList = languages.Select(x => new LanguageDTO
        {
            Id = x.Id,
            LanguageCode = x.LanguageCode,
            LanguageName = x.LanguageName
        }).ToList();

        return languageList;
    }
}




























