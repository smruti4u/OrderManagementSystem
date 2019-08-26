using OrderManagement.Domain.Entities;
using OrderManagement.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Common.UnitOfWork
{
    public interface IUnitOfWork
    {
        MenuRepository<Menu> MenuRepository { get;}
        ResturantRepository<Resturant> ResturantRepository { get;}
        OrderRepository<Order> OrderRepository { get;}
        Task Save();
    }
}
