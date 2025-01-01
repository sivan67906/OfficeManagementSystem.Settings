using MediatR;

namespace Settings.Application.Features.Contracts.Commands.DeleteContract;
public class DeleteContractCommand : IRequest
{
    public Guid Id { get; set; }
}
