//using Settings.Application.DTOs;
using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.JobApplicationPositions.Queries.GetJobApplicationPositionById
{
    public class GetJobApplicationPositionByIdQuery : IRequest<JobApplicationPositionDTO>
    {
        public Guid Id { get; set; }
    }
}
























