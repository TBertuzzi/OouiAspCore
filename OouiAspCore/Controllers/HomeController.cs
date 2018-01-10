using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OouiAspCore.Models;
using OouiAspCore.Pages;
using Ooui.AspNetCore;
using Xamarin.Forms;

namespace OouiAspCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var page = new MainPage();
            var element = page.GetOouiElement();
            return new ElementResult(element, "Minha Nossa!");
        }

     

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
