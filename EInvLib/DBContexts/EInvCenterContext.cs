using EInv.Models.EInv.v32.B2P.E0501;
using EInvLib.Models.EInvCenter;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EInvLib.DBContexts
{
    class EInvCenterContext : DbContext
    {
        protected string connString = @"Data Source=ILLUS-DESKTOP2\SQLEXPRESS;Initial Catalog=testingDB;User ID=dev01;Password=kn4es1uL;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.connString);
        }

        public DbSet<FlowOrder> FlowOrders { get; set; }

        public DbSet<InvoiceAssignNo> InvoiceAssignNos { get; set; }
    }
}
