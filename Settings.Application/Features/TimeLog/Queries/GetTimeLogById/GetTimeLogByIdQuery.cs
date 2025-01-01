//using Settings.Application.DTOs;
using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.TimeLogs.Queries.GetTimeLogById
{
    public class GetTimeLogByIdQuery : IRequest<TimeLogDTO>
    {
        public Guid Id { get; set; }
    }
}




























