using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Settings.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Intial4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BillOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillOrderPrefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillOrderNumberSeperater = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillOrderNumberDigits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillOrderNumberExample = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillOrders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseOrderPrefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseOrderNumberSeperater = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseOrderNumberDigits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseOrderNumberExample = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VendorCredit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorCreditPrefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorCreditNumberSeperater = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorCreditNumberDigits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorCreditNumberExample = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorCredit", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillOrders");

            migrationBuilder.DropTable(
                name: "PurchaseOrders");

            migrationBuilder.DropTable(
                name: "VendorCredit");
        }
    }
}
