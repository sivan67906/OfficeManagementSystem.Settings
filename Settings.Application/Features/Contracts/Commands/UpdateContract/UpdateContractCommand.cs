using MediatR;

namespace Settings.Application.Features.Contracts.Commands.UpdateContract;
public class UpdateContractCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
    public string? ContractPrefix { get; set; }
    public string? ContractNumberSeprator { get; set; }
    public int ContractNumberDigits { get; set; }
    public string? ContractNumberExample { get; set; }
}
