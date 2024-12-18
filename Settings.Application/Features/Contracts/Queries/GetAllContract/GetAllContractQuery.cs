using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.Contracts.Queries.GetAllContract;
public class GetAllContractQuery : IRequest<IEnumerable<ContractDTO>>
{
}
