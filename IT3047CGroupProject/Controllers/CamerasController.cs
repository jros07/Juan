using IT3047CGroupProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT3047CGroupProject.Controllers
{
    public class CamerasController : Controller
    {
        private readonly PhotographyContext context;

        public CamerasController(PhotographyContext ctx)
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