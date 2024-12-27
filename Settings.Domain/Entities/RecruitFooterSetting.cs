using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Settings.Domain.Entities;
public sealed class RecruitFooterSetting
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string? FooterTitle { get; set; }
    public string? FooterSlug { get; set; }
    public int FooterStatusId { get; set; }
    public string? FooterDescription { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; } = true;
}
