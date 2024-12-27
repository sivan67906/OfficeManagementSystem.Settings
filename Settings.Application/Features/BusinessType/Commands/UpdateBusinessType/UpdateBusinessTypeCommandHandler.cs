using Settings.Domain.Entities;
using Settings.Domain.Interfaces;
using MediatR;

namespace Settings.Application.Features.BusinessTypes.Commands.UpdateBusinessType;

internal class UpdateBusinessTypeCommandHandler : IRequestHandler<UpdateBusinessTypeCommand>
{
    private readonly IGenericRepository<BusinessType> _businessTypeRepository;

    public UpdateBusinessTypeCommandHandler(
        IGenericRepository<BusinessType> businessTypeRepository) =>
        _businessTypeRepository = businessTypeRepository;

    public async System.Threading.Tasks.Task Handle(UpdateBusinessTypeCommand request, CancellationToken cancellationToken)
    {
        var businessType = new BusinessType
        {
        };

        await _businessTypeRepository.UpdateAsync(businessType);
    }
}






