using Settings.Application.DTOs;
using MediatR;

namespace Settings.Application.Features.Designations.Queries.GetDesignationById
{
    public class GetDesignationByIdQuery : IRequest<DesignationDTO>
    {
        public int Id { get; set; }
    }
}






