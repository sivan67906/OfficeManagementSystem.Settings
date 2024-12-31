using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Settings.Domain.Entities;
public sealed class TicketAgent
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string? TicketAgentCode { get; set; }
    public string? TicketAgentName { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; } = true;

    public ICollection<FinanceInvoiceSetting>? FinanceInvoiceSettings { get; set; }

}
















