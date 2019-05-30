using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using EInv.Models.EInv.v32.B2C.EInvoice;
using EInv.Models.EInv.v32.B2C.Allowance;
namespace EInvLib.DBContexts
{
    class B2CContext : DbContext
    {
        protected string connString = @"Data Source=ILLUS-DESKTOP2\SQLEXPRESS;Initial Catalog=testingDB;User ID=dev01;Password=kn4es1uL;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.connString);
        }

        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<CancelInvoice> CancelInvoices { get; set; }
        public DbSet<VoidInvoice> VoidInvoices { get; set; }
        public DbSet<Allowance> Allowances { get; set; }
        public DbSet<CancelAllowance> CancelAllowances { get; set; }
    }
}
