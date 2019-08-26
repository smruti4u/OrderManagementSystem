using OrderManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Domain.Repositories
{
    public class OrderRepository<Order> : Genericrepositry<Order> where Order : BaseEntity
    {
        private readonly OrderManagementDbContext dbContext;
        public OrderRepository(OrderManagementDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
