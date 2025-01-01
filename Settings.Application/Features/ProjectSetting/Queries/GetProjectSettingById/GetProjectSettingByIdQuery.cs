//using Settings.Application.DTOs;
using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.ProjectSettings.Queries.GetProjectSettingById
{
    public class GetProjectSettingByIdQuery : IRequest<ProjectSettingDTO>
    {
        public Guid Id { get; set; }
    }
}




















