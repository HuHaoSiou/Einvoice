using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using EInvLib.Models.EInv.v32.B2C.EInvoice;
using EInvLib.Models.EInv.v32.B2C.Allowance;
namespace EInvLib.DBContexts
{
    public class Mig32ontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configs.ConnString_Mig32Context, builder => builder.MigrationsAssembly("Mig32"));
            }
        }

        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<CancelInvoice> CancelInvoices { get; set; }
        public DbSet<VoidInvoice> VoidInvoices { get; set; }
        public DbSet<Allowance> Allowances { get; set; }
        public DbSet<CancelAllowance> CancelAllowances { get; set; }
    }
}
