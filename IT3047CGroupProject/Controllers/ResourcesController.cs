using Microsoft.AspNetCore.Mvc;

namespace IT3047CGroupProject.Controllers
{
    public class ResourcesController : Controller
    {
        // /Resources/About
        public IActionResult About()
        {
            return View();
        }

        // /Resources/Gear
        public IActionResult Gear()
        {
            return View();
        }

        // /Resources/Tips
        public IActionResult Tips()
        {
            return View();
        }
    }
}
