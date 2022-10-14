using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shundorbon.Controllers
{
    public class MasterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
