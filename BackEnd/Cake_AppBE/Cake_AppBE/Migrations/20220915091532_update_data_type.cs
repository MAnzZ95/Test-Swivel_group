using Microsoft.EntityFrameworkCore.Migrations;

namespace Cake_AppBE.Migrations
{
    public partial class update_data_type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "WordCount",
                table: "CakeWordDesigns",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "WordCount",
                table: "CakeWordDesigns",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
