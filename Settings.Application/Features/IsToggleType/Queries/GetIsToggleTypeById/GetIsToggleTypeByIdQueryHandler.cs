using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.IsToggleTypes.Queries.GetIsToggleTypeById;

internal class GetIsToggleTypeByIdQueryHandler : IRequestHandler<GetIsToggleTypeByIdQuery, IsToggleTypeDTO>
{
    private readonly IGenericRepository<IsToggleType> _isToggleTypeRepository;

    public GetIsToggleTypeByIdQueryHandler(
        IGenericRepository<IsToggleType> isToggleTypeRepository) =>
        _isToggleTypeRepository = isToggleTypeRepository;

    public async Task<IsToggleTypeDTO> Handle(GetIsToggleTypeByIdQuery request, CancellationToken cancellationToken)
    {
        var isToggleType = await _isToggleTypeRepository.GetByIdAsync(request.Id);
        if (isToggleType == null) return null;
        return new IsToggleTypeDTO
        {
            Id = isToggleType.Id,
            CQTypeCode = isToggleType.CQTypeCode,
            CQTypeName = isToggleType.CQTypeName
        };
    }
}




























