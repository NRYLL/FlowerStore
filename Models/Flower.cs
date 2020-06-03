using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerStore.Models
{
    public class Flower
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public string Image { get; set; }
        public float price { get; set; }
        public int Quantity { get; set; }
        public FlowerTypes Type { get; set; }
    }
}
