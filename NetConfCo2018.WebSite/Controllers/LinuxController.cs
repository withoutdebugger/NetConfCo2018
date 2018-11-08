using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetConfCo2018.WebSite.Models;

namespace NetConfCo2018.WebSite.Controllers
{
    public class LinuxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
