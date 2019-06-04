using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Libs.Models.Inv
{
    class InvItem
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quty { get; set; }
        public int UnitPrice { get; set; }
        public int Amount { get; set; }
        
    }
}
