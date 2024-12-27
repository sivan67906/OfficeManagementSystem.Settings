using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Settings.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Intial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractSigned = table.Column<bool>(type: "bit", nullable: false),
                    EstimateDeclined = table.Column<bool>(type: "bit", nullable: false),
                    EventInvite = table.Column<bool>(type: "bit", nullable: false),
                    ModulesEmailNotificationEventInviteNew = table.Column<bool>(type: "bit", nullable: false),
                    RecurringExpenseStatusUpdated = table.Column<bool>(type: "bit", nullable: false),
                    NewExpenseAddedbyAdmin = table.Column<bool>(type: "bit", nullable: false),
                    NewExpenseAddedbyMember = table.Column<bool>(type: "bit", nullable: false),
                    Leadnotification = table.Column<bool>(type: "bit", nullable: false),
                    NewOrder = table.Column<bool>(type: "bit", nullable: false),
                    OrderUpdated = table.Column<bool>(type: "bit", nullable: false),
                    NewProductPurchase = table.Column<bool>(type: "bit", nullable: false),
                    NewNoticePublished = table.Column<bool>(type: "bit", nullable: false),
                    UserJoinViaInvitation = table.Column<bool>(type: "bit", nullable: false),
                    NoticeUpdated = table.Column<bool>(type: "bit", nullable: false),
                    UserRegistrationAddedbyAdmin = table.Column<bool>(type: "bit", nullable: false),
                    ModulesEmailNotificationTestNotification = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorCode = table.Column<bool>(type: "bit", nullable: false),
                    NewLeaveApplication = table.Column<bool>(type: "bit", nullable: false),
                    NewLeaveRequest = table.Column<bool>(type: "bit", nullable: false),
                    LeaveApproved = table.Column<bool>(type: "bit", nullable: false),
                    LeaveRejected = table.Column<bool>(type: "bit", nullable: false),
                    LeaveUpdated = table.Column<bool>(type: "bit", nullable: false),
                    MultipleLeaveApplication = table.Column<bool>(type: "bit", nullable: false),
                    NewMultipleLeaveApplication = table.Column<bool>(type: "bit", nullable: false),
                    ProposalApproved = table.Column<bool>(type: "bit", nullable: false),
                    ProposalRejected = table.Column<bool>(type: "bit", nullable: false),
                    NewProposal = table.Column<bool>(type: "bit", nullable: false),
                    RecurringInvoiceStatusUpdated = table.Column<bool>(type: "bit", nullable: false),
                    InvoiceReminder = table.Column<bool>(type: "bit", nullable: false),
                    InvoiceCreated = table.Column<bool>(type: "bit", nullable: false),
                    NewPropoInvoiceUpdatedsal = table.Column<bool>(type: "bit", nullable: false),
                    NewRecurringInvoice = table.Column<bool>(type: "bit", nullable: false),
                    NewPayment = table.Column<bool>(type: "bit", nullable: false),
                    PaymentReceived = table.Column<bool>(type: "bit", nullable: false),
                    PaymentReminder = table.Column<bool>(type: "bit", nullable: false),
                    NewTask = table.Column<bool>(type: "bit", nullable: false),
                    TaskUpdated = table.Column<bool>(type: "bit", nullable: false),
                    TaskCompletedClient = table.Column<bool>(type: "bit", nullable: false),
                    TaskCompleted = table.Column<bool>(type: "bit", nullable: false),
                    NewClientTask = table.Column<bool>(type: "bit", nullable: false),
                    TaskUpdateClient = table.Column<bool>(type: "bit", nullable: false),
                    SubTaskAssigneeAdded = table.Column<bool>(type: "bit", nullable: false),
                    SubTaskCompleted = table.Column<bool>(type: "bit", nullable: false),
                    TaskComment = table.Column<bool>(type: "bit", nullable: false),
                    TaskNote = table.Column<bool>(type: "bit", nullable: false),
                    TaskReminder = table.Column<bool>(type: "bit", nullable: false),
                    AutoTaskReminder = table.Column<bool>(type: "bit", nullable: false),
                    NewTicketRequest = table.Column<bool>(type: "bit", nullable: false),
                    NewSupportTicketRequest = table.Column<bool>(type: "bit", nullable: false),
                    AgentTicket = table.Column<bool>(type: "bit", nullable: false),
                    NewTicketReply = table.Column<bool>(type: "bit", nullable: false),
                    EmployeeAssigntoProject = table.Column<bool>(type: "bit", nullable: false),
                    NewFileUploadedtoProject = table.Column<bool>(type: "bit", nullable: false),
                    ProjectReminder = table.Column<bool>(type: "bit", nullable: false),
                    NewProject = table.Column<bool>(type: "bit", nullable: false),
                    AttendanceReminder = table.Column<bool>(type: "bit", nullable: false),
                    FollowUpReminder = table.Column<bool>(type: "bit", nullable: false),
                    EventReminder = table.Column<bool>(type: "bit", nullable: false),
                    ModulesEmailNotificationEventReminderNew = table.Column<bool>(type: "bit", nullable: false),
                    ModulesEmailNotificationAttendanceReminderNew = table.Column<bool>(type: "bit", nullable: false),
                    RemovalRequestAdminNotification = table.Column<bool>(type: "bit", nullable: false),
                    RemovalRequestApproved = table.Column<bool>(type: "bit", nullable: false),
                    RemovalRequestReject = table.Column<bool>(type: "bit", nullable: false),
                    RemovalRequestApprovedLead = table.Column<bool>(type: "bit", nullable: false),
                    RemovalRequestRejectLead = table.Column<bool>(type: "bit", nullable: false),
                    RemovalRequestRejectUser = table.Column<bool>(type: "bit", nullable: false),
                    RemovalRequestApprovedUser = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Purchases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseOrderPrefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseOrderNumberSeperater = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseOrderNumberDigits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseOrderNumberExample = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillOrderPrefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillOrderNumberSeperater = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillOrderNumberDigits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillOrderNumberExample = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorCreditPrefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorCreditNumberSeperater = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorCreditNumberDigits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorCreditNumberExample = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchases", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Purchases");
        }
    }
}
