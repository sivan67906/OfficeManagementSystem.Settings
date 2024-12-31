using MediatR;

namespace Settings.Application.Features.Languages.Commands.CreateLanguage;

public class CreateLanguageCommand : IRequest
{
    public string? LanguageCode { get; set; }
    public string? LanguageName { get; set; }
}




























