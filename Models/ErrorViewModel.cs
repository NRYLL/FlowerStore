using System;

namespace FlowerStore.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        public string AddFlower { get; set; }
        public string EditFlower { get; set; }
        public string DeleteFlower { get; set; }

        public string NameofFlower { get; set; }

        public int Price { get; set; }

        public int Stock { get; set; }
    }
}
