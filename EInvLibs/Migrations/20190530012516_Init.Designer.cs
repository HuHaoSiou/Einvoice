﻿// <auto-generated />
using System;
using EInvLib.DBContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EInvLib.Migrations
{
    [DbContext(typeof(B2CContext))]
    [Migration("20190530012516_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EInv.Models.EInv.v32.B2C.EInvoice.Amount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Currency");

                    b.Property<bool>("CurrencySpecified");

                    b.Property<decimal>("DiscountAmount");

                    b.Property<bool>("DiscountAmountSpecified");

                    b.Property<decimal>("ExchangeRate");

                    b.Property<bool>("ExchangeRateSpecified");

                    b.Property<decimal>("FreeTaxSalesAmount");

                    b.Property<decimal>("OriginalCurrencyAmount");

                    b.Property<bool>("OriginalCurrencyAmountSpecified");

                    b.Property<decimal>("SalesAmount");

                    b.Property<decimal>("TaxAmount");

                    b.Property<decimal>("TaxRate");

                    b.Property<int>("TaxType");

                    b.Property<decimal>("TotalAmount");

                    b.Property<decimal>("ZeroTaxSalesAmount");

                    b.HasKey("Id");

                    b.ToTable("Amount");
                });

            modelBuilder.Entity("EInv.Models.EInv.v32.B2C.EInvoice.CancelInvoice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BuyerId");

                    b.Property<string>("CancelDate");

                    b.Property<string>("CancelInvoiceNumber");

                    b.Property<string>("CancelReason");

                    b.Property<DateTime>("CancelTime");

                    b.Property<string>("InvoiceDate");

                    b.Property<string>("Remark");

                    b.Property<string>("ReturnTaxDocumentNumber");

                    b.Property<string>("SellerId");

                    b.HasKey("Id");

                    b.ToTable("CancelInvoices");
                });

            modelBuilder.Entity("EInv.Models.EInv.v32.B2C.EInvoice.DetailsProductItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<string>("Description");

                    b.Property<Guid?>("InvoiceId");

                    b.Property<decimal>("Quantity");

                    b.Property<string>("RelateNumber");

                    b.Property<string>("Remark");

                    b.Property<string>("SequenceNumber");

                    b.Property<string>("Unit");

                    b.Property<decimal>("UnitPrice");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.ToTable("DetailsProductItem");
                });

            modelBuilder.Entity("EInv.Models.EInv.v32.B2C.EInvoice.Invoice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AmountId");

                    b.Property<Guid?>("MainId");

                    b.HasKey("Id");

                    b.HasIndex("AmountId");

                    b.HasIndex("MainId");

                    b.ToTable("invoices");
                });

            modelBuilder.Entity("EInv.Models.EInv.v32.B2C.EInvoice.Main", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("BuyerId");

                    b.Property<int>("BuyerRemark");

                    b.Property<bool>("BuyerRemarkSpecified");

                    b.Property<string>("CarrierId1");

                    b.Property<string>("CarrierId2");

                    b.Property<string>("CarrierType");

                    b.Property<string>("Category");

                    b.Property<string>("CheckNumber");

                    b.Property<int>("CustomsClearanceMark");

                    b.Property<bool>("CustomsClearanceMarkSpecified");

                    b.Property<int>("DonateMark");

                    b.Property<string>("GroupMark");

                    b.Property<string>("InvoiceDate");

                    b.Property<string>("InvoiceNumber");

                    b.Property<DateTime>("InvoiceTime");

                    b.Property<int>("InvoiceType");

                    b.Property<string>("MainRemark");

                    b.Property<string>("NPOBAN");

                    b.Property<string>("PermitDate");

                    b.Property<string>("PermitNumber");

                    b.Property<string>("PermitWord");

                    b.Property<string>("PrintMark");

                    b.Property<string>("RandomNumber");

                    b.Property<string>("RelateNumber");

                    b.Property<Guid?>("SellerId");

                    b.Property<string>("TaxCenter");

                    b.HasKey("Id");

                    b.HasIndex("BuyerId");

                    b.HasIndex("SellerId");

                    b.ToTable("Main");
                });

            modelBuilder.Entity("EInv.Models.EInv.v32.B2C.EInvoice.MainBuyer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("CustomerNumber");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FacsimileNumber");

                    b.Property<string>("Identifier");

                    b.Property<string>("Name");

                    b.Property<string>("PersonInCharge");

                    b.Property<string>("RoleRemark");

                    b.Property<string>("TelephoneNumber");

                    b.HasKey("Id");

                    b.ToTable("MainBuyer");
                });

            modelBuilder.Entity("EInv.Models.EInv.v32.B2C.EInvoice.MainSeller", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("CustomerNumber");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FacsimileNumber");

                    b.Property<string>("Identifier");

                    b.Property<string>("Name");

                    b.Property<string>("PersonInCharge");

                    b.Property<string>("RoleRemark");

                    b.Property<string>("TelephoneNumber");

                    b.HasKey("Id");

                    b.ToTable("MainSeller");
                });

            modelBuilder.Entity("EInv.Models.EInv.v32.B2C.EInvoice.VoidInvoice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BuyerId");

                    b.Property<string>("InvoiceDate");

                    b.Property<string>("Remark");

                    b.Property<string>("SellerId");

                    b.Property<string>("VoidDate");

                    b.Property<string>("VoidInvoiceNumber");

                    b.Property<string>("VoidReason");

                    b.Property<DateTime>("VoidTime");

                    b.HasKey("Id");

                    b.ToTable("VoidInvoices");
                });

            modelBuilder.Entity("EInv.Models.EInv.v32.B2C.EInvoice.DetailsProductItem", b =>
                {
                    b.HasOne("EInv.Models.EInv.v32.B2C.EInvoice.Invoice")
                        .WithMany("Details")
                        .HasForeignKey("InvoiceId");
                });

            modelBuilder.Entity("EInv.Models.EInv.v32.B2C.EInvoice.Invoice", b =>
                {
                    b.HasOne("EInv.Models.EInv.v32.B2C.EInvoice.Amount", "Amount")
                        .WithMany()
                        .HasForeignKey("AmountId");

                    b.HasOne("EInv.Models.EInv.v32.B2C.EInvoice.Main", "Main")
                        .WithMany()
                        .HasForeignKey("MainId");
                });

            modelBuilder.Entity("EInv.Models.EInv.v32.B2C.EInvoice.Main", b =>
                {
                    b.HasOne("EInv.Models.EInv.v32.B2C.EInvoice.MainBuyer", "Buyer")
                        .WithMany()
                        .HasForeignKey("BuyerId");

                    b.HasOne("EInv.Models.EInv.v32.B2C.EInvoice.MainSeller", "Seller")
                        .WithMany()
                        .HasForeignKey("SellerId");
                });
#pragma warning restore 612, 618
        }
    }
}
