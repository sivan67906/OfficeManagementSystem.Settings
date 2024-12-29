using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Settings.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedFinanceTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FinanceInvoiceTemplateSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIRBTemplateJsonSettings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceInvoiceTemplateSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinancePrefixSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FICBPrefixJsonSettings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancePrefixSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinanceUnitSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FUnitCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FUnitName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FIsDefault = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceUnitSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinanceInvoiceSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FILogoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FILogoImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FIAuthorisedImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FIAuthorisedImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FILanguageId = table.Column<int>(type: "int", nullable: false),
                    FIDueAfter = table.Column<int>(type: "int", nullable: false),
                    FISendReminderBefore = table.Column<int>(type: "int", nullable: false),
                    FISendReminderAfterEveryId = table.Column<int>(type: "int", nullable: false),
                    FISendReminderAfterEvery = table.Column<int>(type: "int", nullable: false),
                    FICBGeneralJsonSettings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FICBClientInfoJsonSettings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FITerms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FIOtherInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceInvoiceSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinanceInvoiceSettings_Languages_FILanguageId",
                        column: x => x.FILanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FinanceInvoiceSettings_FILanguageId",
                table: "FinanceInvoiceSettings",
                column: "FILanguageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FinanceInvoiceSettings");

            migrationBuilder.DropTable(
                name: "FinanceInvoiceTemplateSettings");

            migrationBuilder.DropTable(
                name: "FinancePrefixSettings");

            migrationBuilder.DropTable(
                name: "FinanceUnitSettings");

            migrationBuilder.DropTable(
                name: "Languages");
        }
    }
}
