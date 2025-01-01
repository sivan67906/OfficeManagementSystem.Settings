using MediatR;

namespace Settings.Application.Features.TimeLogs.Commands.DeleteTimeLog
{
    public class DeleteTimeLogCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}




























