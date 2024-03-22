using Microsoft.AspNetCore.Mvc;
using ProgrammersBlog.Mvc.Areas.Admin.Models;
using System.Diagnostics;

namespace ProgrammersBlog.Mvc.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
