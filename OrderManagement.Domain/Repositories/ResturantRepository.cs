using OrderManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Domain.Repositories
{
    public class ResturantRepository<Resturant> : Genericrepositry<Order> where Resturant : BaseEntity
    {
        private readonly OrderManagementDbContext dbContext;
        public ResturantRepository(OrderManagementDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
