//using Settings.Application.DTOs;
using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.RecruiterSettings.Queries.GetRecruiterSettingById
{
    public class GetRecruiterSettingByIdQuery : IRequest<RecruiterSettingDTO>
    {
        public Guid Id { get; set; }
    }
}
























