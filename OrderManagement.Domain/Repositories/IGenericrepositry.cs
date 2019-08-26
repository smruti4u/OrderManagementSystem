using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OrderManagement.Domain.Repositories
{
    public interface IGenericrepositry<T>
    {      

        Task<T> Add(T entity);
        IEnumerable<T> Find(Func<T, bool> predicate);
        Task<T> FindById(string id);
        IQueryable<T> List();

        Task Update(T entity);
    }
}