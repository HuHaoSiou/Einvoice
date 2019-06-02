using System;
using EInvLib.DBContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using EInvLib;
namespace DBMigration
{
    class Program
    {
        static void Main(string[] args)
        {

            //資料庫遷移
            DatabaseMigrate<EInvCenterContext>(Configs.ConnString_EInvCenterContext);
            DatabaseMigrate<Mig32ontext>(Configs.ConnString_Mig32Context);

        }

        protected static void DatabaseMigrate<context>(string ConnString) where context : DbContext,new()
        {
            var opts = new DbContextOptionsBuilder().UseSqlServer(ConnString).Options;
            using (var c = (context)Activator.CreateInstance(typeof(context),opts ))
            {
                c.Database.Migrate();
            }
        }
    }
}
