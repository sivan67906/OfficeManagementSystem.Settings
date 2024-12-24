using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Settings.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class four : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectReminderPersonId",
                table: "ProjectSettings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSettings_ProjectReminderPersonId",
                table: "ProjectSettings",
                column: "ProjectReminderPersonId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectSettings_ProjectReminderPersons_ProjectReminderPersonId",
                table: "ProjectSettings",
                column: "ProjectReminderPersonId",
                principalTable: "ProjectReminderPersons",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectSettings_ProjectReminderPersons_ProjectReminderPersonId",
                table: "ProjectSettings");

            migrationBuilder.DropIndex(
                name: "IX_ProjectSettings_ProjectReminderPersonId",
                table: "ProjectSettings");

            migrationBuilder.DropColumn(
                name: "ProjectReminderPersonId",
                table: "ProjectSettings");
        }
    }
}
