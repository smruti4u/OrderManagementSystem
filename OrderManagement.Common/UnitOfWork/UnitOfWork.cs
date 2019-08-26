using OrderManagement.Domain;
using OrderManagement.Domain.Entities;
using OrderManagement.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Common.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly OrderManagementDbContext dbContext;

        public MenuRepository<Menu> MenuRepository { get; }
        public ResturantRepository<Resturant> ResturantRepository { get; }
        public OrderRepository<Order> OrderRepository { get; }

        public UnitOfWork()
        {
            dbContext = new OrderManagementDbContext();
            MenuRepository = new MenuRepository<Menu>(dbContext);
            ResturantRepository = new ResturantRepository<Resturant>(dbContext);
            OrderRepository = new OrderRepository<Order>(dbContext);

        }

        public async Task Save()
        {
            await dbContext.SaveChangesAsync().ConfigureAwait(false);
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
