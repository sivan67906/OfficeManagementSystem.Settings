using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.RecruiterSettings.Commands.UpdateRecruiterSetting;

internal class UpdateRecruiterSettingCommandHandler : IRequestHandler<UpdateRecruiterSettingCommand>
{
    private readonly IGenericRepository<RecruiterSetting> _recruiterSettingRepository;

    public UpdateRecruiterSettingCommandHandler(
        IGenericRepository<RecruiterSetting> recruiterSettingRepository) =>
        _recruiterSettingRepository = recruiterSettingRepository;

    public async System.Threading.Tasks.Task Handle(UpdateRecruiterSettingCommand request, CancellationToken cancellationToken)
    {
        var recruiterSetting = new RecruiterSetting
        {
            Id = request.Id,
            RecruiterName = request.RecruiterName,
            RecruiterStatusId = request.RecruiterStatusId,
            UpdatedDate = DateTime.Now
        };

        await _recruiterSettingRepository.UpdateAsync(recruiterSetting);
    }
}
























