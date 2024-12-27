using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.RecruitGeneralSettings.Commands.DeleteRecruitGeneralSetting;

internal class DeleteRecruitGeneralSettingCommandHandler : IRequestHandler<DeleteRecruitGeneralSettingCommand>
{
    private readonly IGenericRepository<RecruitGeneralSetting> _recruitGeneralSettingRepository;

    public DeleteRecruitGeneralSettingCommandHandler(
        IGenericRepository<RecruitGeneralSetting> recruitGeneralSettingRepository) =>
        _recruitGeneralSettingRepository = recruitGeneralSettingRepository;
    public async System.Threading.Tasks.Task Handle(DeleteRecruitGeneralSettingCommand request, CancellationToken cancellationToken)
    {
        await _recruitGeneralSettingRepository.DeleteAsync(request.Id);
    }
}
























