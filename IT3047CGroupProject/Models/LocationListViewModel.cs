namespace IT3047CGroupProject.Models
{
    public class LocationListViewModel
    {
        public List<Location> Locations { get; set; }
        public List<Category> Categories { get; set; }
        public string SelectedCategory { get; set; }
        public string CheckActiveCategory(string category) =>
            category == SelectedCategory ? "active" : "";
    }
}
