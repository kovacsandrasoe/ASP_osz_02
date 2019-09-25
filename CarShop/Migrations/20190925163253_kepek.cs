using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarShop.Migrations
{
    public partial class kepek : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "CarSQLTable",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Plate",
                table: "CarSQLTable",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContentType",
                table: "CarSQLTable",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PictureData",
                table: "CarSQLTable",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentType",
                table: "CarSQLTable");

            migrationBuilder.DropColumn(
                name: "PictureData",
                table: "CarSQLTable");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "CarSQLTable",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Plate",
                table: "CarSQLTable",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 7);
        }
    }
}
