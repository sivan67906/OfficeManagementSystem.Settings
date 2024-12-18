using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.Applications.Queries.GetApplicationById;
public class GetApplicationByIdQueryHandler : IRequestHandler<GetApplicationByIdQuery, ApplicationDTO>
{
    private readonly IGenericRepository<Domain.Entities.Applications> _entitiesRepository;
    public GetApplicationByIdQueryHandler(IGenericRepository<Domain.Entities.Applications> repository) => _entitiesRepository = repository;

    public async Task<ApplicationDTO> Handle(GetApplicationByIdQuery request, CancellationToken cancellationToken)
    {
        var application = await _entitiesRepository.GetByIdAsync(request.Id);
        if (application == null) return null;
        return new ApplicationDTO
        {
            Id = application.Id,
            DateFormat = application.DateFormat,
            TimeFormat = application.TimeFormat,
            DefaultTimezone = application.DefaultTimezone,
            CurrencyId = application.CurrencyId,
            Language = application.Language,
            DatatableRowLimit = application.DatatableRowLimit,
            EmployeeCanExportData = application.EmployeeCanExportData,
        };
    }
}
