using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EInvLib.Models.EInvCenter
{
    /// <summary>
    /// 電子發票字軌
    /// </summary>
    public class EInvTrack
    {
        /// <summary>
        /// 主索引
        /// </summary>
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// 期別
        /// </summary>
        public string YearMonth { get; set; }
        /// <summary>
        /// 字軌
        /// </summary>
        public string Track { get; set; }
        /// <summary>
        /// 起始號碼
        /// </summary>
        public int Begin { get; set; }
        /// <summary>
        /// 結束號碼
        /// </summary>
        public int End { get; set; }
        /// <summary>
        /// 目前號碼
        /// </summary>
        public int Current { get; set; }
        /// <summary>
        /// 發票類別
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 剩餘號碼回傳日
        /// </summary>
        public DateTime? TimeStamp_E0401 { get; set; }
        
    }
}
