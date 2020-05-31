using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FlowerStore.Models;


namespace FlowerStore.Controllers
{
    public class AdminController : Controller

    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Adminstration()
        {
            return View(new Models.AdminListItem());
        }
    }
}
