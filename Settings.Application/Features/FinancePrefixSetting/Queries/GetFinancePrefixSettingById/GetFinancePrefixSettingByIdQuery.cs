//using Settings.Application.DTOs;
using MediatR;
using Settings.Application.DTOs;

namespace Settings.Application.Features.FinancePrefixSettings.Queries.GetFinancePrefixSettingById
{
    public class GetFinancePrefixSettingByIdQuery : IRequest<FinancePrefixSettingDTO>
    {
        public int Id { get; set; }
    }
}




































