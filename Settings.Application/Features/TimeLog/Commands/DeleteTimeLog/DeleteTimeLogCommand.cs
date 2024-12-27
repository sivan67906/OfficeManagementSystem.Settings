using MediatR;

namespace Settings.Application.Features.TimeLogs.Commands.DeleteTimeLog
{
    public class DeleteTimeLogCommand : IRequest
    {
        public int Id { get; set; }
    }
}




























