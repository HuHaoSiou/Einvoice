using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EInvLib.Models.EInvCenter
{
    public class SellerInfo
    {
        [Key]
        public long Id { get; set; }
        [Key, Required]
        public string Name { get; set; }
        [Required]
        public string BAN { get; set; }
        [Required]
        public string EMail { get; set; }

        [ForeignKey("MemberRefId")]
        public Member Owner;
    }
}
