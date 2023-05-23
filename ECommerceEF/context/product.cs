using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceEF.context
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }    
        public decimal Price { get; set; }
        [ForeignKey("Supplyer")]
        public int? SupplyerId { get; set; }
        public Supplyer supplyer { get; set; }

    }
}
