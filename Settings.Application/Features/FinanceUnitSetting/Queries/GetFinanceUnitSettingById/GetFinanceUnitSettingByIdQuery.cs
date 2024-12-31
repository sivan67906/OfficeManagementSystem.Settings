//using Settings.Application.DTOs;
using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.FinanceUnitSettings.Queries.GetFinanceUnitSettingById
{
    public class GetFinanceUnitSettingByIdQuery : IRequest<FinanceUnitSettingDTO>
    {
        public int Id { get; set; }
    }
}
































