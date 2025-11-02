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
        [Route("/Locations/{id?}")]
        public IActionResult Locations(string id)
        {

            var categories = context.Category.OrderBy(c => c.CategoryName).ToList();
            var catID = categories
                .Where(c => c.CategoryName == id)
                .Select(c => c.CategoryId)
                .FirstOrDefault();
            List<Location> locations;
            if ((string.IsNullOrEmpty(id)) || (id == "All"))
            {
                locations = context.Location
                    .OrderBy(l => l.LocationName).ToList();
            }
            else
            {
                locations = context.Location
                    .Where(l => l.CategoryId == catID)
                    .OrderBy(l => l.LocationId).ToList();
            }
            var model = new LocationListViewModel
            {
                Locations = locations,
                Categories = categories,
                SelectedCategory = id
            };
            return View(model);
        }

    }
}
