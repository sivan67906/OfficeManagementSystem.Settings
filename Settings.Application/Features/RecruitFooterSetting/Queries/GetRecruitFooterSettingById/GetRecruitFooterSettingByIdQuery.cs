//using Settings.Application.DTOs;
using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.RecruitFooterSettings.Queries.GetRecruitFooterSettingById
{
    public class GetRecruitFooterSettingByIdQuery : IRequest<RecruitFooterSettingDTO>
    {
        public int Id { get; set; }
    }
}
























