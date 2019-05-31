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
        /// <summary>
        /// 金流訂單
        /// </summary>
        public DbSet<FlowOrder> FlowOrders { get; set; }
        /// <summary>
        /// 配號
        /// </summary>
        public DbSet<InvoiceAssignNo> InvoiceAssignNos { get; set; }
        /// <summary>
        /// 會員
        /// </summary>
        public DbSet<Member> Members { get; set; }
        /// <summary>
        /// 營業人資訊
        /// </summary>
        public DbSet<SellerInfo> SellerInfos { get; set; }
    }
}
