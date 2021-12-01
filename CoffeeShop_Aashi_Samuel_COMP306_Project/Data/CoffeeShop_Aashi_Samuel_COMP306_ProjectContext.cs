using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoffeeShop_Aashi_Samuel_COMP306_Project.Models;

namespace CoffeeShop_Aashi_Samuel_COMP306_Project.Data
{
    public class CoffeeShop_Aashi_Samuel_COMP306_ProjectContext : DbContext
    {
        public CoffeeShop_Aashi_Samuel_COMP306_ProjectContext (DbContextOptions<CoffeeShop_Aashi_Samuel_COMP306_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<CoffeeShop_Aashi_Samuel_COMP306_Project.Models.Cart> Cart { get; set; }
       /* public DbSet<CoffeeShop_Aashi_Samuel_COMP306_Project.Models.Client> Client { get; set; }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>().ToTable("Cart");
            modelBuilder.Entity<Client>().ToTable("Client");
        }

    }
}
