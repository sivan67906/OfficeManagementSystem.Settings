using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.RecruiterSettings.Commands.CreateRecruiterSetting;

internal class CreateRecruiterSettingCommandHandler(
    IGenericRepository<RecruiterSetting> recruiterSettingRepository) : IRequestHandler<CreateRecruiterSettingCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateRecruiterSettingCommand request, CancellationToken cancellationToken)
    {
        var recruiterSetting = new RecruiterSetting
        {
            RecruiterName = request.RecruiterName,
            RecruiterStatusId = request.RecruiterStatusId,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await recruiterSettingRepository.CreateAsync(recruiterSetting);
    }
}
























