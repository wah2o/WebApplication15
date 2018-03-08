using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication15.Controllers
{
    [Authorize(Policy = "RequireAdminRole")]
    public class Admincontroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
