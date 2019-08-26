using Microsoft.EntityFrameworkCore;
using OrderManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Domain.Repositories
{
    public class Genericrepositry<T> : IGenericrepositry<T> where T : BaseEntity
    {
        private readonly OrderManagementDbContext dbContext;

        public DbSet<T> entities { get; set; }
        public Genericrepositry(OrderManagementDbContext dbContext)
        {
            
            this.dbContext = dbContext;
            entities = dbContext.Set<T>();
        }
        public async Task<T> Add(T entity)
        {
           await entities.AddAsync(entity).ConfigureAwait(false);
            return entity;
        }

        public Task<T> FindById(string id)
        {
            return entities.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return entities.Where(predicate);
        }

        public IQueryable<T> List()
        {
            return entities;
        }

        public async Task Update(T entity)
        {
           entities.Update(entity);
           await dbContext.SaveChangesAsync();
        }
    }
}
