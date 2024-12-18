using System.ComponentModel.DataAnnotations.Schema;

namespace Settings.Domain.Entities;
public sealed class Applications
{
    public int Id { get; set; }
    public string? DateFormat { get; set; }
    public string? TimeFormat { get; set; }
    public string? DefaultTimezone { get; set; }
    public string? Language { get; set; }
    public string? DatatableRowLimit { get; set; }
    public bool EmployeeCanExportData { get; set; }

    [ForeignKey(nameof(CurrencyId))]
    public int CurrencyId { get; set; }
    public Currency? Currency { get; set; }
}
