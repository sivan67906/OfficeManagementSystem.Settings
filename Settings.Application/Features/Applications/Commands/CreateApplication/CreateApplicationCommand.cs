using MediatR;

namespace Settings.Application.Features.Applications.Commands.CreateApplication;
public class CreateApplicationCommand : IRequest<int>
{
    
    public string? DateFormat { get; set; }
    public string? TimeFormat { get; set; }
    public string? DefaultTimezone { get; set; }
    public int CurrencyId { get; set; }
    public string? Language { get; set; }
    public string? DatatableRowLimit { get; set; }
    public bool EmployeeCanExportData { get; set; }
}
