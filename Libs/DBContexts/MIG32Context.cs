using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using EInvLib.Models.EInv.v32.B2C.EInvoice;
using EInvLib.Models.EInv.v32.B2C.Allowance;
using EInvLib.Models.EInv.v32.B2P.E0401;
using EInvLib.Models.EInv.v32.B2P.E0402;
using EInvLib.Models.EInv.v32.B2P.E0501;

namespace EInvLib.DBContexts
{
    public class Mig32Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configs.ConnString_Mig32Context, builder => builder.MigrationsAssembly("Libs"));
                
            }
        }

        public DbSet<Invoice> C0401_Invoices { get; set; }
        public DbSet<CancelInvoice> C0501_CancelInvoices { get; set; }
        public DbSet<VoidInvoice> C0702_VoidInvoices { get; set; }
        public DbSet<Allowance> D0401_Allowances { get; set; }
        public DbSet<CancelAllowance> D0501_CancelAllowances { get; set; }
        public DbSet<BranchTrack> E0401_BranchTracks { get; set; }
        public DbSet<BranchTrackBlank> E0402_BranchTrackBlanks { get; set; }
        public DbSet<InvoiceAssignNo> E0501_InvoiceAssignNos { get; set; }
    }
}
