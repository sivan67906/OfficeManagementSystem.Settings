using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Settings.Domain.Entities;
public sealed class RecruitNotificationSetting
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string? CBEMailJsonSettings { get; set; }
    public string? CBEMailNotificationJsonSettings { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; } = true;
}
