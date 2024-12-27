using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Settings.Domain.Entities;
public sealed class IsToggleType
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string? ToggleCode { get; set; }
    public string? ToggleName { get; set; }
    public bool IsChecked { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; } = true;
}




