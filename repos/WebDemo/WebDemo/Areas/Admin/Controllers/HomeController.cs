using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDemo.Areas.Admin.Controllers
{   [Route("admin.html", Name = "AdminIndex")]
    [Area("Admin")]
    [Authorize()]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
