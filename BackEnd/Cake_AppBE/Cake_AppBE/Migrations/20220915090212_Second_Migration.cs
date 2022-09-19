using Microsoft.EntityFrameworkCore.Migrations;

namespace Cake_AppBE.Migrations
{
    public partial class Second_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CakeWordDesigns",
                columns: table => new
                {
                    WordId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WordCount = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CakeWordDesigns", x => x.WordId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CakeWordDesigns");
        }
    }
}
