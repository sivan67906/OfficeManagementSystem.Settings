using MediatR;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.BusinessTypes.Commands.CreateBusinessType;

internal class CreateBusinessTypeCommandHandler(
    IGenericRepository<BusinessType> businessTypeRepository) : IRequestHandler<CreateBusinessTypeCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateBusinessTypeCommand request, CancellationToken cancellationToken)
    {
        var businessType = new BusinessType
        {

        };

        await businessTypeRepository.CreateAsync(businessType);
    }
}






