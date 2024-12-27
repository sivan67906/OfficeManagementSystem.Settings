using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.RecruiterSettings.Commands.DeleteRecruiterSetting;

internal class DeleteRecruiterSettingCommandHandler : IRequestHandler<DeleteRecruiterSettingCommand>
{
    private readonly IGenericRepository<RecruiterSetting> _recruiterSettingRepository;

    public DeleteRecruiterSettingCommandHandler(
        IGenericRepository<RecruiterSetting> recruiterSettingRepository) =>
        _recruiterSettingRepository = recruiterSettingRepository;
    public async System.Threading.Tasks.Task Handle(DeleteRecruiterSettingCommand request, CancellationToken cancellationToken)
    {
        await _recruiterSettingRepository.DeleteAsync(request.Id);
    }
}
























