using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.RecruitFooterSettings.Commands.CreateRecruitFooterSetting;

internal class CreateRecruitFooterSettingCommandHandler(
    IGenericRepository<RecruitFooterSetting> recruitFooterSettingRepository) : IRequestHandler<CreateRecruitFooterSettingCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateRecruitFooterSettingCommand request, CancellationToken cancellationToken)
    {
        var recruitFooterSetting = new RecruitFooterSetting
        {
            FooterTitle = request.FooterTitle,
            FooterSlug = request.FooterSlug,
            FooterStatusId = request.FooterStatusId,
            FooterDescription = request.FooterDescription,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await recruitFooterSettingRepository.CreateAsync(recruitFooterSetting);
    }
}
























