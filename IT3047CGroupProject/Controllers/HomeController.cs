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

        // 1. Updated Index to just return the view (no DB call needed for the Welcome page)
        public IActionResult Index()
        {
            return View();
        }

        // 2. Locations logic stays here as per current structure
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
                locations = context.Location.OrderBy(l => l.LocationName).ToList();
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

        // Privacy Action removed as requested
    }
}