using MediatR;

namespace Settings.Application.Features.RecruiterSettings.Commands.CreateRecruiterSetting;

public class CreateRecruiterSettingCommand : IRequest
{
    public string? RecruiterName { get; set; }
    public int RecruiterStatusId { get; set; }
}
























