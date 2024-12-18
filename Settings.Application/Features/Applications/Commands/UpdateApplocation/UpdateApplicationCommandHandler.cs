using MediatR;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Applications.Commands.UpdateApplocation;
public class UpdateApplicationCommandHandler : IRequestHandler<UpdateApplicationCommand, int>
{
    private readonly IGenericRepository<Domain.Entities.Applications> _appliRepo;
    public UpdateApplicationCommandHandler(IGenericRepository<Domain.Entities.Applications> repository) => _appliRepo = repository;

    public async Task<int> Handle(UpdateApplicationCommand request, CancellationToken cancellationToken)
    {
        var application = new Domain.Entities.Applications
        {
            Id = request.Id,
            DateFormat = request.DateFormat,
            TimeFormat = request.TimeFormat,
            DefaultTimezone = request.DefaultTimezone,
            CurrencyId = request.CurrencyId,
            Language = request.Language,
            DatatableRowLimit = request.DatatableRowLimit,
            EmployeeCanExportData = request.EmployeeCanExportData,

        };
        await _appliRepo.UpdateAsync(application);
        return request.Id;
    }
}
