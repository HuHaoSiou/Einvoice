using EInv.Models.EInv.v32.B2P.E0501;
using EInvLib.Models.EInvCenter;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EInvLib.DBContexts
{
    public class EInvCenterContext : IdentityDbContext
    {
        protected string connString = @"Data Source=ILLUS-DESKTOP2\SQLEXPRESS;Initial Catalog=testingDB;User ID=dev01;Password=kn4es1uL;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public EInvCenterContext() { }
        public EInvCenterContext(DbContextOptions<EInvCenterContext> options):base(options){}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.connString, b => b.MigrationsAssembly("EInvCenter"));
        }
        /// <summary>
        /// 金流訂單
        /// </summary>
        public DbSet<FlowOrder> FlowOrders { get; set; }
        /// <summary>
        /// 配號
        /// </summary>
        public DbSet<InvoiceAssignNo> InvoiceAssignNos { get; set; }
        /// <summary>
        /// 營業人資訊
        /// </summary>
        public DbSet<SellerInfo> SellerInfos { get; set; }
        //public DbSet<Member> Members { get; set; }
    }
}
