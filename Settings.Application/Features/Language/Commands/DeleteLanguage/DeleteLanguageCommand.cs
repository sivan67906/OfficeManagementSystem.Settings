using MediatR;

namespace Settings.Application.Features.Languages.Commands.DeleteLanguage
{
    public class DeleteLanguageCommand : IRequest
    {
        public int Id { get; set; }
    }
}




























