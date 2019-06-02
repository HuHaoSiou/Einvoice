using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EInvLib
{
    /// <summary>
    /// 設定與環境常數
    /// </summary>
    public class Configs
    {
        /// <summary>
        /// Mig路徑
        /// </summary>
        public const string PATH_TURNKEY_C0401 = @"";
        public const string PATH_TURNKEY_C0501 = @"";
        public const string PATH_TURNKEY_C0701 = @"";
        /// <summary>
        /// 連接字串
        /// </summary>
        public const string ConnString_Mig32Context = @"Data Source=ILLUS-DESKTOP2\SQLEXPRESS;Initial Catalog=testingDB;User ID=dev01;Password=kn4es1uL;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string ConnString_EInvCenterContext = @"Data Source=ILLUS-DESKTOP2\SQLEXPRESS;Initial Catalog=testingDB;User ID=dev01;Password=kn4es1uL;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        /// <summary>
        /// Mig檔暫存目錄
        /// </summary>
        public const string PATH_XML_GENERATE_TEMP = @"";
    }
}
