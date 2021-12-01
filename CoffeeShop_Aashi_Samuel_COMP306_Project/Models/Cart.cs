using System;
using System.Collections.Generic;

#nullable disable

namespace CoffeeShop_Aashi_Samuel_COMP306_Project.Models
{
    public partial class Cart
    {
        public int CartId { get; set; }
        public int ClientId { get; set; }
        public string ItemName { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public byte[] ItemImage { get; set; }

        public virtual Client Client { get; set; }
    }
}
