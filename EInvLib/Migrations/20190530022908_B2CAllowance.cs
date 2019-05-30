using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EInvLib.Migrations
{
    public partial class B2CAllowance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailsProductItem_invoices_InvoiceId",
                table: "DetailsProductItem");

            migrationBuilder.DropForeignKey(
                name: "FK_invoices_Amount_AmountId",
                table: "invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_invoices_Main_MainId",
                table: "invoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VoidInvoices",
                table: "VoidInvoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_invoices",
                table: "invoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CancelInvoices",
                table: "CancelInvoices");

            migrationBuilder.EnsureSchema(
                name: "EInv");

            migrationBuilder.RenameTable(
                name: "VoidInvoices",
                newName: "C0701",
                newSchema: "EInv");

            migrationBuilder.RenameTable(
                name: "invoices",
                newName: "C0401",
                newSchema: "EInv");

            migrationBuilder.RenameTable(
                name: "CancelInvoices",
                newName: "C0501",
                newSchema: "EInv");

            migrationBuilder.RenameIndex(
                name: "IX_invoices_MainId",
                schema: "EInv",
                table: "C0401",
                newName: "IX_C0401_MainId");

            migrationBuilder.RenameIndex(
                name: "IX_invoices_AmountId",
                schema: "EInv",
                table: "C0401",
                newName: "IX_C0401_AmountId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_C0701",
                schema: "EInv",
                table: "C0701",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_C0401",
                schema: "EInv",
                table: "C0401",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_C0501",
                schema: "EInv",
                table: "C0501",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "D0401_Amount",
                schema: "EInv",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TaxAmount = table.Column<decimal>(nullable: false),
                    TotalAmount = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D0401_Amount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D0401_MainBuyer",
                schema: "EInv",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Identifier = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PersonInCharge = table.Column<string>(nullable: true),
                    TelephoneNumber = table.Column<string>(nullable: true),
                    FacsimileNumber = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    CustomerNumber = table.Column<string>(nullable: true),
                    RoleRemark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D0401_MainBuyer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D0401_MainSeller",
                schema: "EInv",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Identifier = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PersonInCharge = table.Column<string>(nullable: true),
                    TelephoneNumber = table.Column<string>(nullable: true),
                    FacsimileNumber = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    CustomerNumber = table.Column<string>(nullable: true),
                    RoleRemark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D0401_MainSeller", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D0501",
                schema: "EInv",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CancelAllowanceNumber = table.Column<string>(nullable: true),
                    AllowanceDate = table.Column<string>(nullable: true),
                    BuyerId = table.Column<string>(nullable: true),
                    SellerId = table.Column<string>(nullable: true),
                    CancelDate = table.Column<string>(nullable: true),
                    CancelTime = table.Column<DateTime>(nullable: false),
                    CancelReason = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D0501", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D0401_Main",
                schema: "EInv",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AllowanceNumber = table.Column<string>(nullable: true),
                    AllowanceDate = table.Column<string>(nullable: true),
                    SellerId = table.Column<Guid>(nullable: true),
                    BuyerId = table.Column<Guid>(nullable: true),
                    AllowanceType = table.Column<int>(nullable: false),
                    Attachment = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D0401_Main", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D0401_Main_D0401_MainBuyer_BuyerId",
                        column: x => x.BuyerId,
                        principalSchema: "EInv",
                        principalTable: "D0401_MainBuyer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_D0401_Main_D0401_MainSeller_SellerId",
                        column: x => x.SellerId,
                        principalSchema: "EInv",
                        principalTable: "D0401_MainSeller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "D0401",
                schema: "EInv",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    MainId = table.Column<Guid>(nullable: true),
                    AmountId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D0401", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D0401_D0401_Amount_AmountId",
                        column: x => x.AmountId,
                        principalSchema: "EInv",
                        principalTable: "D0401_Amount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_D0401_D0401_Main_MainId",
                        column: x => x.MainId,
                        principalSchema: "EInv",
                        principalTable: "D0401_Main",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "D0401_DetailsProductItem",
                schema: "EInv",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    OriginalInvoiceDate = table.Column<string>(nullable: true),
                    OriginalInvoiceNumber = table.Column<string>(nullable: true),
                    OriginalSequenceNumber = table.Column<string>(nullable: true),
                    OriginalDescription = table.Column<string>(nullable: true),
                    Quantity = table.Column<decimal>(nullable: false),
                    Unit = table.Column<string>(nullable: true),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    Tax = table.Column<decimal>(nullable: false),
                    AllowanceSequenceNumber = table.Column<string>(nullable: true),
                    TaxType = table.Column<int>(nullable: false),
                    AllowanceId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D0401_DetailsProductItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D0401_DetailsProductItem_D0401_AllowanceId",
                        column: x => x.AllowanceId,
                        principalSchema: "EInv",
                        principalTable: "D0401",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_D0401_AmountId",
                schema: "EInv",
                table: "D0401",
                column: "AmountId");

            migrationBuilder.CreateIndex(
                name: "IX_D0401_MainId",
                schema: "EInv",
                table: "D0401",
                column: "MainId");

            migrationBuilder.CreateIndex(
                name: "IX_D0401_DetailsProductItem_AllowanceId",
                schema: "EInv",
                table: "D0401_DetailsProductItem",
                column: "AllowanceId");

            migrationBuilder.CreateIndex(
                name: "IX_D0401_Main_BuyerId",
                schema: "EInv",
                table: "D0401_Main",
                column: "BuyerId");

            migrationBuilder.CreateIndex(
                name: "IX_D0401_Main_SellerId",
                schema: "EInv",
                table: "D0401_Main",
                column: "SellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailsProductItem_C0401_InvoiceId",
                table: "DetailsProductItem",
                column: "InvoiceId",
                principalSchema: "EInv",
                principalTable: "C0401",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_C0401_Amount_AmountId",
                schema: "EInv",
                table: "C0401",
                column: "AmountId",
                principalTable: "Amount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_C0401_Main_MainId",
                schema: "EInv",
                table: "C0401",
                column: "MainId",
                principalTable: "Main",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailsProductItem_C0401_InvoiceId",
                table: "DetailsProductItem");

            migrationBuilder.DropForeignKey(
                name: "FK_C0401_Amount_AmountId",
                schema: "EInv",
                table: "C0401");

            migrationBuilder.DropForeignKey(
                name: "FK_C0401_Main_MainId",
                schema: "EInv",
                table: "C0401");

            migrationBuilder.DropTable(
                name: "D0401_DetailsProductItem",
                schema: "EInv");

            migrationBuilder.DropTable(
                name: "D0501",
                schema: "EInv");

            migrationBuilder.DropTable(
                name: "D0401",
                schema: "EInv");

            migrationBuilder.DropTable(
                name: "D0401_Amount",
                schema: "EInv");

            migrationBuilder.DropTable(
                name: "D0401_Main",
                schema: "EInv");

            migrationBuilder.DropTable(
                name: "D0401_MainBuyer",
                schema: "EInv");

            migrationBuilder.DropTable(
                name: "D0401_MainSeller",
                schema: "EInv");

            migrationBuilder.DropPrimaryKey(
                name: "PK_C0701",
                schema: "EInv",
                table: "C0701");

            migrationBuilder.DropPrimaryKey(
                name: "PK_C0501",
                schema: "EInv",
                table: "C0501");

            migrationBuilder.DropPrimaryKey(
                name: "PK_C0401",
                schema: "EInv",
                table: "C0401");

            migrationBuilder.RenameTable(
                name: "C0701",
                schema: "EInv",
                newName: "VoidInvoices");

            migrationBuilder.RenameTable(
                name: "C0501",
                schema: "EInv",
                newName: "CancelInvoices");

            migrationBuilder.RenameTable(
                name: "C0401",
                schema: "EInv",
                newName: "invoices");

            migrationBuilder.RenameIndex(
                name: "IX_C0401_MainId",
                table: "invoices",
                newName: "IX_invoices_MainId");

            migrationBuilder.RenameIndex(
                name: "IX_C0401_AmountId",
                table: "invoices",
                newName: "IX_invoices_AmountId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VoidInvoices",
                table: "VoidInvoices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CancelInvoices",
                table: "CancelInvoices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_invoices",
                table: "invoices",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailsProductItem_invoices_InvoiceId",
                table: "DetailsProductItem",
                column: "InvoiceId",
                principalTable: "invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_invoices_Amount_AmountId",
                table: "invoices",
                column: "AmountId",
                principalTable: "Amount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_invoices_Main_MainId",
                table: "invoices",
                column: "MainId",
                principalTable: "Main",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
