using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EInvLib.Models.EInvCenter
{
    class Member
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Account { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string EMail { get; set; }
        public int IsActived { get; set; }

        [InverseProperty("SellerInfo")]
        public ICollection<SellerInfo> Sellers;

    }
}
