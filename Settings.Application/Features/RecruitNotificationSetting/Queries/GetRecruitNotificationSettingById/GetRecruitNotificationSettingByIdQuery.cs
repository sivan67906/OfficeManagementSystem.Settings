//using Settings.Application.DTOs;
using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.RecruitNotificationSettings.Queries.GetRecruitNotificationSettingById
{
    public class GetRecruitNotificationSettingByIdQuery : IRequest<RecruitNotificationSettingDTO>
    {
        public Guid Id { get; set; }
    }
}
























