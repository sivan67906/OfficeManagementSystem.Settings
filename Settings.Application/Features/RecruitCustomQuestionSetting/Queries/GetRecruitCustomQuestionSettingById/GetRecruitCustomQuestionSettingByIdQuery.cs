//using Settings.Application.DTOs;
using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.RecruitCustomQuestionSettings.Queries.GetRecruitCustomQuestionSettingById
{
    public class GetRecruitCustomQuestionSettingByIdQuery : IRequest<RecruitCustomQuestionSettingDTO>
    {
        public Guid Id { get; set; }
    }
}
























