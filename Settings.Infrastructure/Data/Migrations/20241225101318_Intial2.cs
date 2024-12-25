using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Settings.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Intial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SendReminderTo",
                table: "ProjectSettings");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SendReminderTo",
                table: "ProjectSettings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
