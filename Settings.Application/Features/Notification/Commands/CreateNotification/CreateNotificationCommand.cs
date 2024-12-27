using MediatR;

namespace Settings.Application.Features.Notifications.Commands.CreateNotification;

public class CreateNotificationCommand : IRequest
{
    public string? CommonNotificationJson { get; set; }
    public string? LeaveNotificationJson { get; set; }
    public string? ProposalNotificationJson { get; set; }
    public string? InvoiceNotificationJson { get; set; }
    public string? PaymentNotificationJson { get; set; }
    public string? TaskNotificationJson { get; set; }
    public string? TicketNotificationJson { get; set; }
    public string? ProjectNotificationJson { get; set; }
    public string? ReminderNotificationJson { get; set; }
    public string? RequestNotificationJson { get; set; }
}





























