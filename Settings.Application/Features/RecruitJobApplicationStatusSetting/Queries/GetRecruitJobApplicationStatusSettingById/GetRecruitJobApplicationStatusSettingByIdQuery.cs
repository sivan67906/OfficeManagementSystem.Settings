//using Settings.Application.DTOs;
using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.RecruitJobApplicationStatusSettings.Queries.GetRecruitJobApplicationStatusSettingById
{
    public class GetRecruitJobApplicationStatusSettingByIdQuery : IRequest<RecruitJobApplicationStatusSettingDTO>
    {
        public int Id { get; set; }
    }
}
























