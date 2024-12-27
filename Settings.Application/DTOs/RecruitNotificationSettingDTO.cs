namespace Settings.Application.DTOs;
public class RecruitNotificationSettingDTO
{
    public int Id { get; set; }
    public string? CBEMailJsonSettings { get; set; }
    public string? CBEMailNotificationJsonSettings { get; set; }
}