using Microsoft.EntityFrameworkCore;

namespace IT3047CGroupProject.Models
{
    public class PhotographyContext : DbContext
    {
        public PhotographyContext(DbContextOptions<PhotographyContext> options) : base(options)
        {
        }
        public DbSet<Camera> Cameras { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Location> Location { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Camera>().HasData(
                new Camera
                {
                    CameraId = 1,
                    CameraName = "Canon EOS R5",
                    CameraBrand = "Canon",
                    CameraModel = "EOS R5",
                    CameraPrice = 3899.00m,
                    CameraDescription = "A high-resolution full-frame mirrorless camera with advanced features."
                },
                new Camera
                {
                    CameraId = 2,
                    CameraName = "Nikon Z7 II",
                    CameraBrand = "Nikon",
                    CameraModel = "Z7 II",
                    CameraPrice = 2999.95m,
                    CameraDescription = "A versatile full-frame mirrorless camera with excellent image quality."
                },
                new Camera
                {
                    CameraId = 3,
                    CameraName = "Sony Alpha a7 III",
                    CameraBrand = "Sony",
                    CameraModel = "Alpha a7 III",
                    CameraPrice = 1998.00m,
                    CameraDescription = "A popular full-frame mirrorless camera known for its speed and performance."
                });

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Landscape"
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Portrait"
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Wildlife"
                });

            modelBuilder.Entity<Location>().HasData(
                new Location
                {
                    LocationId = 1,
                    LocationName = "Yosemite National Park",
                    LocationDescription = "A stunning location known for its waterfalls and granite cliffs.",
                    CategoryId = 1
                },
                new Location
                {
                    LocationId = 2,
                    LocationName = "Central Park",
                    LocationDescription = "A popular urban park perfect for portrait photography.",
                    CategoryId = 2
                },
                new Location
                {
                    LocationId = 3,
                    LocationName = "Serengeti National Park",
                    LocationDescription = "A prime location for capturing wildlife in their natural habitat.",
                    CategoryId = 3
                });
        }
    }
}
