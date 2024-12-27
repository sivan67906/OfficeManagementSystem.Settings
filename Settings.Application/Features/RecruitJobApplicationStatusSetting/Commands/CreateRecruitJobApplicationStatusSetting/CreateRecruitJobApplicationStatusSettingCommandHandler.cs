using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.RecruitJobApplicationStatusSettings.Commands.CreateRecruitJobApplicationStatusSetting;

internal class CreateRecruitJobApplicationStatusSettingCommandHandler(
    IGenericRepository<RecruitJobApplicationStatusSetting> recruitJobApplicationStatusSettingRepository) : IRequestHandler<CreateRecruitJobApplicationStatusSettingCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateRecruitJobApplicationStatusSettingCommand request, CancellationToken cancellationToken)
    {
        var recruitJobApplicationStatusSetting = new RecruitJobApplicationStatusSetting
        {
            JobApplicationPositionId = request.JobApplicationPositionId,
            JobApplicationCategoryId = request.JobApplicationCategoryId,
            JASStatus = request.JASStatus,
            JASColor = request.JASColor,
            JASIsModelChecked = request.JASIsModelChecked,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await recruitJobApplicationStatusSettingRepository.CreateAsync(recruitJobApplicationStatusSetting);
    }
}
























