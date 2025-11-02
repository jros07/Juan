using System.Diagnostics;
using IT3047CGroupProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT3047CGroupProject.Controllers
{
    public class HomeController : Controller
    {
        private PhotographyContext context;
        public HomeController(PhotographyContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            var cameras = context.Cameras.ToList();
            return View(cameras);
        }

    }
}
