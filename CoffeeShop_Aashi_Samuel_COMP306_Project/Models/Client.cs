using System;
using System.Collections.Generic;

#nullable disable

namespace CoffeeShop_Aashi_Samuel_COMP306_Project.Models
{
    public partial class Client
    {
        public Client()
        {
            Carts = new HashSet<Cart>();
        }

        public int ClientId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
    }
}
