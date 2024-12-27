using MediatR;
using Settings.Application.DTOs;
using Settings.Domain.Entities;
using Settings.Domain.Interfaces;

namespace Settings.Application.Features.RecruiterSettings.Queries.GetRecruiterSettingById;

internal class GetRecruiterSettingByIdQueryHandler : IRequestHandler<GetRecruiterSettingByIdQuery, RecruiterSettingDTO>
{
    private readonly IGenericRepository<RecruiterSetting> _recruiterSettingRepository;

    public GetRecruiterSettingByIdQueryHandler(
        IGenericRepository<RecruiterSetting> recruiterSettingRepository) =>
        _recruiterSettingRepository = recruiterSettingRepository;

    public async Task<RecruiterSettingDTO> Handle(GetRecruiterSettingByIdQuery request, CancellationToken cancellationToken)
    {
        var recruiterSetting = await _recruiterSettingRepository.GetByIdAsync(request.Id);
        if (recruiterSetting == null) return null;
        return new RecruiterSettingDTO
        {
            Id = recruiterSetting.Id,
            RecruiterName = recruiterSetting.RecruiterName,
            RecruiterStatusId = recruiterSetting.RecruiterStatusId
        };
    }
}
























