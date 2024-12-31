using MediatR;

namespace Settings.Application.Features.Languages.Commands.UpdateLanguage;

public class UpdateLanguageCommand : IRequest
{
    public int Id { get; set; }
    public string? LanguageCode { get; set; }
    public string? LanguageName { get; set; }
}




























