using EInvLib.Models.EInv.v32.B2P.E0501;
using EInvLib.Models.EInvCenter;
using EInvLib;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EInvLib.DBContexts
{
    public class EInvCenterContext : IdentityDbContext
    {
        public EInvCenterContext() { }
        public EInvCenterContext(DbContextOptions<EInvCenterContext> options):base(options){}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configs.ConnString_EInvCenterContext, builder => builder.MigrationsAssembly("Libs"));
            }
        }
        /// <summary>
        /// 金流訂單
        /// </summary>
        public DbSet<FlowOrder> FlowOrders { get; set; }
        /// <summary>
        /// 營業人資訊
        /// </summary>
        public DbSet<SellerInfo> SellerInfos { get; set; }
    }
}
