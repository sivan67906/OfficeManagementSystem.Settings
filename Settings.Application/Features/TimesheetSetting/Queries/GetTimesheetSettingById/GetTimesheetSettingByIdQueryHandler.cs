using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.TimesheetSettings.Queries.GetTimesheetSettingById;

internal class GetTimesheetSettingByIdQueryHandler : IRequestHandler<GetTimesheetSettingByIdQuery, TimesheetSettingDTO>
{
    private readonly IGenericRepository<TimesheetSetting> _timesheetSettingRepository;

    public GetTimesheetSettingByIdQueryHandler(
        IGenericRepository<TimesheetSetting> timesheetSettingRepository) =>
        _timesheetSettingRepository = timesheetSettingRepository;

    public async Task<TimesheetSettingDTO> Handle(GetTimesheetSettingByIdQuery request, CancellationToken cancellationToken)
    {
        var timesheetSetting = await _timesheetSettingRepository.GetByIdAsync(request.Id);
        if (timesheetSetting == null) return null;
        return new TimesheetSettingDTO
        {
            Id = timesheetSetting.Id,
            TimesheetSettingCode = timesheetSetting.TimesheetSettingCode,
            TimesheetSettingName = timesheetSetting.TimesheetSettingName
        };
    }
}




































