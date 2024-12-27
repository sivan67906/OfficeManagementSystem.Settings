using Settings.Domain.Entities;
using Settings.Domain.Interfaces;
using MediatR;

namespace Settings.Application.Features.BusinessTypes.Queries.GetAllBusinessTypes;

internal class GetAllBusinessTypesQueryHandler : IRequestHandler<GetAllBusinessTypesQuery, IEnumerable<BusinessTypeDTO>>
{
    private readonly IGenericRepository<BusinessType> _businessTypeRepository;

    public GetAllBusinessTypesQueryHandler(
        IGenericRepository<BusinessType> businessTypeRepository) =>
        _businessTypeRepository = businessTypeRepository;

    public async Task<IEnumerable<BusinessTypeDTO>> Handle(GetAllBusinessTypesQuery request, CancellationToken cancellationToken)
    {
        var companies = await _businessTypeRepository.GetAllAsync();

        var businessTypeList = companies.Select(x => new BusinessTypeDTO
        {
            Id = x.Id,
            Name = x.Name,
            Code = x.Code,
            CreatedDate = x.CreatedDate,
            UpdatedDate = x.UpdatedDate,
            IsActive = x.IsActive
        }).ToList();

        return businessTypeList;
    }
}






