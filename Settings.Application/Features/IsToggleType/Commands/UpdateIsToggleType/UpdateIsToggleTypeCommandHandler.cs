namespace Settings.Application.Features.IsToggleTypes.Commands.UpdateIsToggleType;

internal class UpdateIsToggleTypeCommandHandler : IRequestHandler<UpdateIsToggleTypeCommand>
{
    private readonly IGenericRepository<IsToggleType> _isToggleTypeRepository;

    public UpdateIsToggleTypeCommandHandler(
        //IGenericRepository<IsToggleType> isToggleTypeRepository) =>
        _isToggleTypeRepository = isToggleTypeRepository;

    public async System.Threading.Tasks.Task Handle(UpdateIsToggleTypeCommand request, CancellationToken cancellationToken)
    {
        var isToggleType = new IsToggleType
        {
            Id = request.Id,
            CQTypeCode = request.CQTypeCode,
            CQTypeName = request.CQTypeName,
            UpdatedDate = DateTime.Now
        };

        await _isToggleTypeRepository.UpdateAsync(isToggleType);
    }
}




























