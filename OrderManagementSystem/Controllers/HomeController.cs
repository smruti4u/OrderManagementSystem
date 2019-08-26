using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.Common.UnitOfWork;
using OrderManagement.Domain.Entities;
using OrderManagement.Domain.Repositories;
using OrderManagementSystem.Models;

namespace OrderManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        public HomeController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            Order newOrder = new Order() {
                Id = "7080e15c-29fb-4636-be0a-bd1b793732b1",
                Name = "Order For Box Biriyani",
                Price = 140.45f
            };
         unitOfWork.OrderRepository.Update(newOrder).GetAwaiter().GetResult();

          
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
