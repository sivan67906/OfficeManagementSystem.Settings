using MediatR;

namespace Settings.Application.Features.Contracts.Commands.DeleteContract;
public class DeleteContractCommand : IRequest
{
    public int Id { get; set; }
}
