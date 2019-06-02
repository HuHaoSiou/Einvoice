﻿// <auto-generated />
using System;
using EInvLib.DBContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EInvLib.Migrations.EInvCenter
{
    [DbContext(typeof(EInvCenterContext))]
    partial class EInvCenterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EInv.Models.EInv.v32.B2P.E0501.InvoiceAssignNo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ban");

                    b.Property<string>("InvoiceBeginNo");

                    b.Property<long>("InvoiceBooklet");

                    b.Property<string>("InvoiceEndNo");

                    b.Property<string>("InvoiceTrack");

                    b.Property<int>("InvoiceType");

                    b.Property<string>("YearMonth");

                    b.HasKey("Id");

                    b.ToTable("E0501","EInv");
                });

            modelBuilder.Entity("EInvLib.Models.EInvCenter.FlowOrder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<int>("CustomerID");

                    b.Property<string>("FlowOrderNo");

                    b.Property<int>("IsDonate");

                    b.Property<string>("OrderNo");

                    b.Property<int?>("PayAmount");

                    b.Property<DateTime?>("PayTimeStamp");

                    b.Property<string>("PayType");

                    b.Property<DateTime>("TimeStamp");

                    b.HasKey("Id");

                    b.ToTable("FlowOrders");
                });
#pragma warning restore 612, 618
        }
    }
}