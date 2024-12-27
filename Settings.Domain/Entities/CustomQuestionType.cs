using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Settings.Domain.Entities;
public sealed class CustomQuestionType
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string? CQTypeCode { get; set; }
    public string? CQTypeName { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; } = true;

    public ICollection<RecruitCustomQuestionSetting>? recruitCustomQuestionSettings { get; set; }
}