using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Languages.Queries.GetLanguageById;

internal class GetLanguageByIdQueryHandler : IRequestHandler<GetLanguageByIdQuery, LanguageDTO>
{
    private readonly IGenericRepository<Language> _languageRepository;

    public GetLanguageByIdQueryHandler(
        IGenericRepository<Language> languageRepository) =>
        _languageRepository = languageRepository;

    public async Task<LanguageDTO> Handle(GetLanguageByIdQuery request, CancellationToken cancellationToken)
    {
        var language = await _languageRepository.GetByIdAsync(request.Id);
        if (language == null) return null;
        return new LanguageDTO
        {
            Id = language.Id,
            LanguageCode = language.LanguageCode,
            LanguageName = language.LanguageName
        };
    }
}




























