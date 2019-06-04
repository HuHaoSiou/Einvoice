using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EinvLib.Models.Inv
{
    /// <summary>
    /// 發票容器
    /// </summary>
    public class Invoice
    {
        [Key]
        public Guid Id { get; set; }
        public string Track { get; set; }
        public string No { get; set; }
        public DateTime TimeStamp { get; set; }
        public int TaxAmount { get; set; }
        public int SalesAmount { get; set; }
        public int TotalAmount { get; set; }
        
    }
}
