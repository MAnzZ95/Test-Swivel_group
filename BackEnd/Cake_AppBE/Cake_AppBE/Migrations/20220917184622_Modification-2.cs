using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cake_AppBE.Migrations
{
    public partial class Modification2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Peice",
                table: "SizeOfCakes");

            migrationBuilder.DropColumn(
                name: "SizeName",
                table: "SizeOfCakes");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "SizeOfCakes",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "SizeOfCakes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "Orders",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "ToppingSize",
                table: "CakeToppings",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "SizeOfCakes");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "SizeOfCakes");

            migrationBuilder.DropColumn(
                name: "Message",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderDate",
                table: "Orders");

            migrationBuilder.AddColumn<double>(
                name: "Peice",
                table: "SizeOfCakes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "SizeName",
                table: "SizeOfCakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ToppingSize",
                table: "CakeToppings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
