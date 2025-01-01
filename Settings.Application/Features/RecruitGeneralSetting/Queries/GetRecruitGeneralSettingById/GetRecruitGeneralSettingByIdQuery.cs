//using Settings.Application.DTOs;
using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.RecruitGeneralSettings.Queries.GetRecruitGeneralSettingById
{
    public class GetRecruitGeneralSettingByIdQuery : IRequest<RecruitGeneralSettingDTO>
    {
        public Guid Id { get; set; }
    }
}
























