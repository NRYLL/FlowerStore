using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerStore.Models
{
    public class AdminListItem
    {
        public int Id { get; set; }
        public int AddFlower { get; set; }
        public string EditFlower { get; set; }
        public string DeleteFlower { get; set; }

        public string NameofFlower { get; set; }

        public int Price { get; set; }

        public int Stock { get; set; }

    }
}
