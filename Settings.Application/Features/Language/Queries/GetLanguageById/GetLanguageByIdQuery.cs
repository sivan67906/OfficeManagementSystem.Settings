//using Settings.Application.DTOs;
using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Languages.Queries.GetLanguageById
{
    public class GetLanguageByIdQuery : IRequest<LanguageDTO>
    {
        public Guid Id { get; set; }
    }
}




























