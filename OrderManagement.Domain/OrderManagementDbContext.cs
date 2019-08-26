using Microsoft.EntityFrameworkCore;
using OrderManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Domain
{
    public class OrderManagementDbContext :  DbContext
    {
        public OrderManagementDbContext()
        {
            
        }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<Resturant> Resturants { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB; Database = Order");
        }
    }
}
