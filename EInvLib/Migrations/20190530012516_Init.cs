using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EInvLib.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amount",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    SalesAmount = table.Column<decimal>(nullable: false),
                    FreeTaxSalesAmount = table.Column<decimal>(nullable: false),
                    ZeroTaxSalesAmount = table.Column<decimal>(nullable: false),
                    TaxType = table.Column<int>(nullable: false),
                    TaxRate = table.Column<decimal>(nullable: false),
                    TaxAmount = table.Column<decimal>(nullable: false),
                    TotalAmount = table.Column<decimal>(nullable: false),
                    DiscountAmount = table.Column<decimal>(nullable: false),
                    DiscountAmountSpecified = table.Column<bool>(nullable: false),
                    OriginalCurrencyAmount = table.Column<decimal>(nullable: false),
                    OriginalCurrencyAmountSpecified = table.Column<bool>(nullable: false),
                    ExchangeRate = table.Column<decimal>(nullable: false),
                    ExchangeRateSpecified = table.Column<bool>(nullable: false),
                    Currency = table.Column<int>(nullable: false),
                    CurrencySpecified = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CancelInvoices",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CancelInvoiceNumber = table.Column<string>(nullable: true),
                    InvoiceDate = table.Column<string>(nullable: true),
                    BuyerId = table.Column<string>(nullable: true),
                    SellerId = table.Column<string>(nullable: true),
                    CancelDate = table.Column<string>(nullable: true),
                    CancelTime = table.Column<DateTime>(nullable: false),
                    CancelReason = table.Column<string>(nullable: true),
                    ReturnTaxDocumentNumber = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CancelInvoices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainBuyer",
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
                    table.PrimaryKey("PK_MainBuyer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainSeller",
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
                    table.PrimaryKey("PK_MainSeller", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VoidInvoices",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    VoidInvoiceNumber = table.Column<string>(nullable: true),
                    InvoiceDate = table.Column<string>(nullable: true),
                    BuyerId = table.Column<string>(nullable: true),
                    SellerId = table.Column<string>(nullable: true),
                    VoidDate = table.Column<string>(nullable: true),
                    VoidTime = table.Column<DateTime>(nullable: false),
                    VoidReason = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoidInvoices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InvoiceNumber = table.Column<string>(nullable: true),
                    InvoiceDate = table.Column<string>(nullable: true),
                    InvoiceTime = table.Column<DateTime>(nullable: false),
                    SellerId = table.Column<Guid>(nullable: true),
                    BuyerId = table.Column<Guid>(nullable: true),
                    CheckNumber = table.Column<string>(nullable: true),
                    BuyerRemark = table.Column<int>(nullable: false),
                    BuyerRemarkSpecified = table.Column<bool>(nullable: false),
                    MainRemark = table.Column<string>(nullable: true),
                    CustomsClearanceMark = table.Column<int>(nullable: false),
                    CustomsClearanceMarkSpecified = table.Column<bool>(nullable: false),
                    TaxCenter = table.Column<string>(nullable: true),
                    PermitDate = table.Column<string>(nullable: true),
                    PermitWord = table.Column<string>(nullable: true),
                    PermitNumber = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    RelateNumber = table.Column<string>(nullable: true),
                    InvoiceType = table.Column<int>(nullable: false),
                    GroupMark = table.Column<string>(nullable: true),
                    DonateMark = table.Column<int>(nullable: false),
                    CarrierType = table.Column<string>(nullable: true),
                    CarrierId1 = table.Column<string>(nullable: true),
                    CarrierId2 = table.Column<string>(nullable: true),
                    PrintMark = table.Column<string>(nullable: true),
                    NPOBAN = table.Column<string>(nullable: true),
                    RandomNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Main", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Main_MainBuyer_BuyerId",
                        column: x => x.BuyerId,
                        principalTable: "MainBuyer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Main_MainSeller_SellerId",
                        column: x => x.SellerId,
                        principalTable: "MainSeller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "invoices",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    MainId = table.Column<Guid>(nullable: true),
                    AmountId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_invoices_Amount_AmountId",
                        column: x => x.AmountId,
                        principalTable: "Amount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_invoices_Main_MainId",
                        column: x => x.MainId,
                        principalTable: "Main",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetailsProductItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Quantity = table.Column<decimal>(nullable: false),
                    Unit = table.Column<string>(nullable: true),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    SequenceNumber = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    RelateNumber = table.Column<string>(nullable: true),
                    InvoiceId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailsProductItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailsProductItem_invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetailsProductItem_InvoiceId",
                table: "DetailsProductItem",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_invoices_AmountId",
                table: "invoices",
                column: "AmountId");

            migrationBuilder.CreateIndex(
                name: "IX_invoices_MainId",
                table: "invoices",
                column: "MainId");

            migrationBuilder.CreateIndex(
                name: "IX_Main_BuyerId",
                table: "Main",
                column: "BuyerId");

            migrationBuilder.CreateIndex(
                name: "IX_Main_SellerId",
                table: "Main",
                column: "SellerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CancelInvoices");

            migrationBuilder.DropTable(
                name: "DetailsProductItem");

            migrationBuilder.DropTable(
                name: "VoidInvoices");

            migrationBuilder.DropTable(
                name: "invoices");

            migrationBuilder.DropTable(
                name: "Amount");

            migrationBuilder.DropTable(
                name: "Main");

            migrationBuilder.DropTable(
                name: "MainBuyer");

            migrationBuilder.DropTable(
                name: "MainSeller");
        }
    }
}
