using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EInvLib.Migrations.EInvCenter
{
    public partial class E0501 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "EInv");

            migrationBuilder.CreateTable(
                name: "FlowOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    PayTimeStamp = table.Column<DateTime>(nullable: true),
                    PayAmount = table.Column<int>(nullable: true),
                    PayType = table.Column<string>(nullable: true),
                    FlowOrderNo = table.Column<string>(nullable: true),
                    OrderNo = table.Column<string>(nullable: true),
                    IsDonate = table.Column<int>(nullable: false),
                    CustomerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowOrders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "E0501",
                schema: "EInv",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Ban = table.Column<string>(nullable: true),
                    InvoiceType = table.Column<int>(nullable: false),
                    YearMonth = table.Column<string>(nullable: true),
                    InvoiceTrack = table.Column<string>(nullable: true),
                    InvoiceBeginNo = table.Column<string>(nullable: true),
                    InvoiceEndNo = table.Column<string>(nullable: true),
                    InvoiceBooklet = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E0501", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlowOrders");

            migrationBuilder.DropTable(
                name: "E0501",
                schema: "EInv");
        }
    }
}
