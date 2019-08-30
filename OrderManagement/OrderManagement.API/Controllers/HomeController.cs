using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.API.Models;
using OrderManagement.Business.Managers;
namespace OrderManagement.API.Controllers
{
    public class HomeController : Controller
    {
        Business.Managers.OrderManager.OrderManager objOrderManger = new OrderManagement.Business.Managers.OrderManager.OrderManager();
        public IActionResult Index()
        {
       

          objOrderManger.Create(new Common.Entities.Order {Id="ORD0001",Status="Rejected" });

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
