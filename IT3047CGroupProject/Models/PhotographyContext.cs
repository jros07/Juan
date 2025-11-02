using Microsoft.EntityFrameworkCore;

namespace IT3047CGroupProject.Models
{
    public class PhotographyContext : DbContext
    {
        public PhotographyContext(DbContextOptions<PhotographyContext> options) : base(options)
        {
        }
        public DbSet<Camera> Cameras { get; set; }

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
        }
    }
}
