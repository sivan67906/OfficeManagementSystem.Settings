using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Contracts.Commands.DeleteContract;
public class DeleteContractCommandHandler : IRequestHandler<DeleteContractCommand>
{
    private readonly IGenericRepository<Contract> _contractRepository;
    public DeleteContractCommandHandler(IGenericRepository<Contract> contractRepository) => _contractRepository = contractRepository;
public async Task Handle(DeleteContractCommand request, CancellationToken cancellationToken)
    {
        if (request == null || request.Id == null)
        {
            throw new ArgumentNullException(nameof(request), "Request or Request.Id cannot be null.");
        }

        await _contractRepository.DeleteAsync(request.Id);
    }
}
