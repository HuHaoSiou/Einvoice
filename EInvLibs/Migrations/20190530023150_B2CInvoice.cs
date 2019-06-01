using Microsoft.EntityFrameworkCore.Migrations;

namespace EInvLib.Migrations
{
    public partial class B2CInvoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailsProductItem_C0401_InvoiceId",
                table: "DetailsProductItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Main_MainBuyer_BuyerId",
                table: "Main");

            migrationBuilder.DropForeignKey(
                name: "FK_Main_MainSeller_SellerId",
                table: "Main");

            migrationBuilder.DropForeignKey(
                name: "FK_C0401_Amount_AmountId",
                schema: "EInv",
                table: "C0401");

            migrationBuilder.DropForeignKey(
                name: "FK_C0401_Main_MainId",
                schema: "EInv",
                table: "C0401");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MainSeller",
                table: "MainSeller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MainBuyer",
                table: "MainBuyer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Main",
                table: "Main");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetailsProductItem",
                table: "DetailsProductItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Amount",
                table: "Amount");

            migrationBuilder.RenameTable(
                name: "MainSeller",
                newName: "C0401_MainSeller",
                newSchema: "EInv");

            migrationBuilder.RenameTable(
                name: "MainBuyer",
                newName: "C0401_MainBuyer",
                newSchema: "EInv");

            migrationBuilder.RenameTable(
                name: "Main",
                newName: "C0401_Main",
                newSchema: "EInv");

            migrationBuilder.RenameTable(
                name: "DetailsProductItem",
                newName: "C0401_DetailsProductItem",
                newSchema: "EInv");

            migrationBuilder.RenameTable(
                name: "Amount",
                newName: "C0401_Amount",
                newSchema: "EInv");

            migrationBuilder.RenameIndex(
                name: "IX_Main_SellerId",
                schema: "EInv",
                table: "C0401_Main",
                newName: "IX_C0401_Main_SellerId");

            migrationBuilder.RenameIndex(
                name: "IX_Main_BuyerId",
                schema: "EInv",
                table: "C0401_Main",
                newName: "IX_C0401_Main_BuyerId");

            migrationBuilder.RenameIndex(
                name: "IX_DetailsProductItem_InvoiceId",
                schema: "EInv",
                table: "C0401_DetailsProductItem",
                newName: "IX_C0401_DetailsProductItem_InvoiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_C0401_MainSeller",
                schema: "EInv",
                table: "C0401_MainSeller",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_C0401_MainBuyer",
                schema: "EInv",
                table: "C0401_MainBuyer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_C0401_Main",
                schema: "EInv",
                table: "C0401_Main",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_C0401_DetailsProductItem",
                schema: "EInv",
                table: "C0401_DetailsProductItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_C0401_Amount",
                schema: "EInv",
                table: "C0401_Amount",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_C0401_C0401_Amount_AmountId",
                schema: "EInv",
                table: "C0401",
                column: "AmountId",
                principalSchema: "EInv",
                principalTable: "C0401_Amount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_C0401_C0401_Main_MainId",
                schema: "EInv",
                table: "C0401",
                column: "MainId",
                principalSchema: "EInv",
                principalTable: "C0401_Main",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_C0401_DetailsProductItem_C0401_InvoiceId",
                schema: "EInv",
                table: "C0401_DetailsProductItem",
                column: "InvoiceId",
                principalSchema: "EInv",
                principalTable: "C0401",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_C0401_Main_C0401_MainBuyer_BuyerId",
                schema: "EInv",
                table: "C0401_Main",
                column: "BuyerId",
                principalSchema: "EInv",
                principalTable: "C0401_MainBuyer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_C0401_Main_C0401_MainSeller_SellerId",
                schema: "EInv",
                table: "C0401_Main",
                column: "SellerId",
                principalSchema: "EInv",
                principalTable: "C0401_MainSeller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_C0401_C0401_Amount_AmountId",
                schema: "EInv",
                table: "C0401");

            migrationBuilder.DropForeignKey(
                name: "FK_C0401_C0401_Main_MainId",
                schema: "EInv",
                table: "C0401");

            migrationBuilder.DropForeignKey(
                name: "FK_C0401_DetailsProductItem_C0401_InvoiceId",
                schema: "EInv",
                table: "C0401_DetailsProductItem");

            migrationBuilder.DropForeignKey(
                name: "FK_C0401_Main_C0401_MainBuyer_BuyerId",
                schema: "EInv",
                table: "C0401_Main");

            migrationBuilder.DropForeignKey(
                name: "FK_C0401_Main_C0401_MainSeller_SellerId",
                schema: "EInv",
                table: "C0401_Main");

            migrationBuilder.DropPrimaryKey(
                name: "PK_C0401_MainSeller",
                schema: "EInv",
                table: "C0401_MainSeller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_C0401_MainBuyer",
                schema: "EInv",
                table: "C0401_MainBuyer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_C0401_Main",
                schema: "EInv",
                table: "C0401_Main");

            migrationBuilder.DropPrimaryKey(
                name: "PK_C0401_DetailsProductItem",
                schema: "EInv",
                table: "C0401_DetailsProductItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_C0401_Amount",
                schema: "EInv",
                table: "C0401_Amount");

            migrationBuilder.RenameTable(
                name: "C0401_MainSeller",
                schema: "EInv",
                newName: "MainSeller");

            migrationBuilder.RenameTable(
                name: "C0401_MainBuyer",
                schema: "EInv",
                newName: "MainBuyer");

            migrationBuilder.RenameTable(
                name: "C0401_Main",
                schema: "EInv",
                newName: "Main");

            migrationBuilder.RenameTable(
                name: "C0401_DetailsProductItem",
                schema: "EInv",
                newName: "DetailsProductItem");

            migrationBuilder.RenameTable(
                name: "C0401_Amount",
                schema: "EInv",
                newName: "Amount");

            migrationBuilder.RenameIndex(
                name: "IX_C0401_Main_SellerId",
                table: "Main",
                newName: "IX_Main_SellerId");

            migrationBuilder.RenameIndex(
                name: "IX_C0401_Main_BuyerId",
                table: "Main",
                newName: "IX_Main_BuyerId");

            migrationBuilder.RenameIndex(
                name: "IX_C0401_DetailsProductItem_InvoiceId",
                table: "DetailsProductItem",
                newName: "IX_DetailsProductItem_InvoiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MainSeller",
                table: "MainSeller",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MainBuyer",
                table: "MainBuyer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Main",
                table: "Main",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetailsProductItem",
                table: "DetailsProductItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Amount",
                table: "Amount",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailsProductItem_C0401_InvoiceId",
                table: "DetailsProductItem",
                column: "InvoiceId",
                principalSchema: "EInv",
                principalTable: "C0401",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Main_MainBuyer_BuyerId",
                table: "Main",
                column: "BuyerId",
                principalTable: "MainBuyer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Main_MainSeller_SellerId",
                table: "Main",
                column: "SellerId",
                principalTable: "MainSeller",
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
    }
}
