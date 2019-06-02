using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Libs.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "C0401_Amount",
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
                    table.PrimaryKey("PK_C0401_Amount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "C0401_MainBuyer",
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
                    table.PrimaryKey("PK_C0401_MainBuyer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "C0401_MainSeller",
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
                    table.PrimaryKey("PK_C0401_MainSeller", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "C0501",
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
                    table.PrimaryKey("PK_C0501", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "C0701",
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
                    table.PrimaryKey("PK_C0701", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D0401_Amount",
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
                name: "E0401_Main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    HeadBan = table.Column<string>(nullable: true),
                    BranchBan = table.Column<string>(nullable: true),
                    InvoiceType = table.Column<int>(nullable: false),
                    YearMonth = table.Column<string>(nullable: true),
                    InvoiceTrack = table.Column<string>(nullable: true),
                    InvoiceBeginNo = table.Column<string>(nullable: true),
                    InvoiceEndNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E0401_Main", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "E0402_Main",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    HeadBan = table.Column<string>(nullable: true),
                    BranchBan = table.Column<string>(nullable: true),
                    InvoiceType = table.Column<int>(nullable: false),
                    YearMonth = table.Column<string>(nullable: true),
                    InvoiceTrack = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E0402_Main", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "E0501",
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

            migrationBuilder.CreateTable(
                name: "C0401_Main",
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
                    table.PrimaryKey("PK_C0401_Main", x => x.Id);
                    table.ForeignKey(
                        name: "FK_C0401_Main_C0401_MainBuyer_BuyerId",
                        column: x => x.BuyerId,
                        principalTable: "C0401_MainBuyer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_C0401_Main_C0401_MainSeller_SellerId",
                        column: x => x.SellerId,
                        principalTable: "C0401_MainSeller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "D0401_Main",
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
                        principalTable: "D0401_MainBuyer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_D0401_Main_D0401_MainSeller_SellerId",
                        column: x => x.SellerId,
                        principalTable: "D0401_MainSeller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "E0401",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    MainId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E0401", x => x.Id);
                    table.ForeignKey(
                        name: "FK_E0401_E0401_Main_MainId",
                        column: x => x.MainId,
                        principalTable: "E0401_Main",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "E0402",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    MainId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E0402", x => x.Id);
                    table.ForeignKey(
                        name: "FK_E0402_E0402_Main_MainId",
                        column: x => x.MainId,
                        principalTable: "E0402_Main",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "C0401",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    MainId = table.Column<Guid>(nullable: true),
                    AmountId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C0401", x => x.Id);
                    table.ForeignKey(
                        name: "FK_C0401_C0401_Amount_AmountId",
                        column: x => x.AmountId,
                        principalTable: "C0401_Amount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_C0401_C0401_Main_MainId",
                        column: x => x.MainId,
                        principalTable: "C0401_Main",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "D0401",
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
                        principalTable: "D0401_Amount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_D0401_D0401_Main_MainId",
                        column: x => x.MainId,
                        principalTable: "D0401_Main",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "E0401_DetailsBranchTrackItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InvoiceBeginNo = table.Column<string>(nullable: true),
                    InvoiceEndNo = table.Column<string>(nullable: true),
                    InvoiceBooklet = table.Column<long>(nullable: false),
                    BranchTrackId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E0401_DetailsBranchTrackItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_E0401_DetailsBranchTrackItem_E0401_BranchTrackId",
                        column: x => x.BranchTrackId,
                        principalTable: "E0401",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "E0402_DetailsBranchTrackBlankItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InvoiceBeginNo = table.Column<string>(nullable: true),
                    InvoiceEndNo = table.Column<string>(nullable: true),
                    BranchTrackBlankId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_E0402_DetailsBranchTrackBlankItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_E0402_DetailsBranchTrackBlankItem_E0402_BranchTrackBlankId",
                        column: x => x.BranchTrackBlankId,
                        principalTable: "E0402",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "C0401_DetailsProductItem",
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
                    table.PrimaryKey("PK_C0401_DetailsProductItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_C0401_DetailsProductItem_C0401_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "C0401",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "D0401_DetailsProductItem",
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
                        principalTable: "D0401",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_C0401_AmountId",
                table: "C0401",
                column: "AmountId");

            migrationBuilder.CreateIndex(
                name: "IX_C0401_MainId",
                table: "C0401",
                column: "MainId");

            migrationBuilder.CreateIndex(
                name: "IX_C0401_DetailsProductItem_InvoiceId",
                table: "C0401_DetailsProductItem",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_C0401_Main_BuyerId",
                table: "C0401_Main",
                column: "BuyerId");

            migrationBuilder.CreateIndex(
                name: "IX_C0401_Main_SellerId",
                table: "C0401_Main",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_D0401_AmountId",
                table: "D0401",
                column: "AmountId");

            migrationBuilder.CreateIndex(
                name: "IX_D0401_MainId",
                table: "D0401",
                column: "MainId");

            migrationBuilder.CreateIndex(
                name: "IX_D0401_DetailsProductItem_AllowanceId",
                table: "D0401_DetailsProductItem",
                column: "AllowanceId");

            migrationBuilder.CreateIndex(
                name: "IX_D0401_Main_BuyerId",
                table: "D0401_Main",
                column: "BuyerId");

            migrationBuilder.CreateIndex(
                name: "IX_D0401_Main_SellerId",
                table: "D0401_Main",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_E0401_MainId",
                table: "E0401",
                column: "MainId");

            migrationBuilder.CreateIndex(
                name: "IX_E0401_DetailsBranchTrackItem_BranchTrackId",
                table: "E0401_DetailsBranchTrackItem",
                column: "BranchTrackId");

            migrationBuilder.CreateIndex(
                name: "IX_E0402_MainId",
                table: "E0402",
                column: "MainId");

            migrationBuilder.CreateIndex(
                name: "IX_E0402_DetailsBranchTrackBlankItem_BranchTrackBlankId",
                table: "E0402_DetailsBranchTrackBlankItem",
                column: "BranchTrackBlankId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "C0401_DetailsProductItem");

            migrationBuilder.DropTable(
                name: "C0501");

            migrationBuilder.DropTable(
                name: "C0701");

            migrationBuilder.DropTable(
                name: "D0401_DetailsProductItem");

            migrationBuilder.DropTable(
                name: "D0501");

            migrationBuilder.DropTable(
                name: "E0401_DetailsBranchTrackItem");

            migrationBuilder.DropTable(
                name: "E0402_DetailsBranchTrackBlankItem");

            migrationBuilder.DropTable(
                name: "E0501");

            migrationBuilder.DropTable(
                name: "C0401");

            migrationBuilder.DropTable(
                name: "D0401");

            migrationBuilder.DropTable(
                name: "E0401");

            migrationBuilder.DropTable(
                name: "E0402");

            migrationBuilder.DropTable(
                name: "C0401_Amount");

            migrationBuilder.DropTable(
                name: "C0401_Main");

            migrationBuilder.DropTable(
                name: "D0401_Amount");

            migrationBuilder.DropTable(
                name: "D0401_Main");

            migrationBuilder.DropTable(
                name: "E0401_Main");

            migrationBuilder.DropTable(
                name: "E0402_Main");

            migrationBuilder.DropTable(
                name: "C0401_MainBuyer");

            migrationBuilder.DropTable(
                name: "C0401_MainSeller");

            migrationBuilder.DropTable(
                name: "D0401_MainBuyer");

            migrationBuilder.DropTable(
                name: "D0401_MainSeller");
        }
    }
}
