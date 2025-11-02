using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IT3047CGroupProject.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cameras",
                columns: table => new
                {
                    CameraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CameraName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CameraBrand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CameraModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CameraPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CameraDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cameras", x => x.CameraId);
                });

            migrationBuilder.InsertData(
                table: "Cameras",
                columns: new[] { "CameraId", "CameraBrand", "CameraDescription", "CameraModel", "CameraName", "CameraPrice" },
                values: new object[,]
                {
                    { 1, "Canon", "A high-resolution full-frame mirrorless camera with advanced features.", "EOS R5", "Canon EOS R5", 3899.00m },
                    { 2, "Nikon", "A versatile full-frame mirrorless camera with excellent image quality.", "Z7 II", "Nikon Z7 II", 2999.95m },
                    { 3, "Sony", "A popular full-frame mirrorless camera known for its speed and performance.", "Alpha a7 III", "Sony Alpha a7 III", 1998.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cameras");
        }
    }
}
