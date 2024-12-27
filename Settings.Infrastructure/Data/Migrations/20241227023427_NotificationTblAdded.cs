using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Settings.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class NotificationTblAdded : Migration
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
                    CommonNotificationJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeaveNotificationJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProposalNotificationJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceNotificationJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentNotificationJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskNotificationJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TicketNotificationJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectNotificationJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReminderNotificationJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestNotificationJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");
        }
    }
}
