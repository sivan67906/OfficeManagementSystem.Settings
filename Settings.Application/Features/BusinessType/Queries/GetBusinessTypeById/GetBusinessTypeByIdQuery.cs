using Settings.Domain.Entities;
using MediatR;

namespace Settings.Application.Features.BusinessTypes.Queries.GetBusinessTypeById
{
    public class GetBusinessTypeByIdQuery : IRequest<BusinessTypeDTO>
    {
        public Guid Id { get; set; }
    }
}






