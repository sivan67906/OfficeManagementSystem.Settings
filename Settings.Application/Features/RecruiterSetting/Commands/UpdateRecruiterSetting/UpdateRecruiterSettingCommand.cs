using MediatR;

namespace Settings.Application.Features.RecruiterSettings.Commands.UpdateRecruiterSetting;

public class UpdateRecruiterSettingCommand : IRequest
{
    public Guid Id { get; set; }
    public string? RecruiterName { get; set; }
    public int RecruiterStatusId { get; set; }
}
























