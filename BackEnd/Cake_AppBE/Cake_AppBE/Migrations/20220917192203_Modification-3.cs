using Microsoft.EntityFrameworkCore.Migrations;

namespace Cake_AppBE.Migrations
{
    public partial class Modification3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "SizeOfCakes",
                type: "decimal(5, 2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "ShapeOfCakes",
                type: "decimal(5, 2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "OrderAmount",
                table: "Orders",
                type: "decimal(6, 2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "WordCount",
                table: "CakeWordDesigns",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "CakeWordDesigns",
                type: "decimal(5, 2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "CakeToppings",
                type: "decimal(5, 2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "SizeOfCakes",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5, 2)");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "ShapeOfCakes",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5, 2)");

            migrationBuilder.AlterColumn<double>(
                name: "OrderAmount",
                table: "Orders",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6, 2)");

            migrationBuilder.AlterColumn<string>(
                name: "WordCount",
                table: "CakeWordDesigns",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "CakeWordDesigns",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5, 2)");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "CakeToppings",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5, 2)");
        }
    }
}
