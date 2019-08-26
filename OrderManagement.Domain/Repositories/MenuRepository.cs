using OrderManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Domain.Repositories
{
    public class MenuRepository<Menu> : Genericrepositry<Menu> where Menu : BaseEntity
    {
        private readonly OrderManagementDbContext dbContext;
        public MenuRepository(OrderManagementDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
