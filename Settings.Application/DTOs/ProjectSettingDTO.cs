namespace Settings.Application.DTOs;
public class ProjectSettingDTO
{
    public int Id { get; set; }
    public bool IsSendReminder { get; set; }
    public int ProjectReminderPersonId { get; set; }
    public int RemindBefore { get; set; }
    public ICollection<ProjectReminderPersonDTO>? projectReminderPersons { get; set; }

}
