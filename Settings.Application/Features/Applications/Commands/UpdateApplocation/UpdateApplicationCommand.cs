﻿using MediatR;

namespace Settings.Application.Features.Applications.Commands.UpdateApplocation;
public class UpdateApplicationCommand : IRequest<int>
{
    public int Id { get; set; }
    public string? DateFormat { get; set; }
    public string? TimeFormat { get; set; }
    public string? DefaultTimezone { get; set; }
    public int CurrencyId { get; set; }
    public string? CurrencySymbol { get; set; }
    public string? CurrencyCode { get; set; }
    public string? Language { get; set; }
    public string? DatatableRowLimit { get; set; }
    public bool EmployeeCanExportData { get; set; }
}
