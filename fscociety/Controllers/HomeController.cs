using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using fscociety.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace fscociety.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       //categoryini istfade etmek
        //CategoryManager cm = new CategoryManager(new EFCategoryRepository());


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //listi almaq
            //var values = cm.GetList();

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
