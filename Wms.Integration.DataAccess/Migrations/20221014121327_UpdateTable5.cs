using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wms.Integration.DataAccess.Migrations
{
    public partial class UpdateTable5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Skt",
                table: "ItemExtras",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Description2",
                table: "ItemExtras",
                type: "NVarChar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ItemExtras",
                type: "NVarChar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ItemExtras",
                type: "Int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionShelves",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 14, 15, 13, 26, 586, DateTimeKind.Local).AddTicks(2795),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 14, 15, 7, 28, 610, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionShelf",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 14, 15, 13, 26, 586, DateTimeKind.Local).AddTicks(1918),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 14, 15, 7, 28, 609, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionLine",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 14, 15, 13, 26, 585, DateTimeKind.Local).AddTicks(9479),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 14, 15, 7, 28, 609, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Decomposition",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 14, 15, 13, 26, 585, DateTimeKind.Local).AddTicks(7090),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 14, 15, 7, 28, 609, DateTimeKind.Local).AddTicks(5653));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Skt",
                table: "ItemExtras",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<string>(
                name: "Description2",
                table: "ItemExtras",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVarChar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ItemExtras",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVarChar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "ItemExtras",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "Int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionShelves",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 14, 15, 7, 28, 610, DateTimeKind.Local).AddTicks(607),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 14, 15, 13, 26, 586, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionShelf",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 14, 15, 7, 28, 609, DateTimeKind.Local).AddTicks(9926),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 14, 15, 13, 26, 586, DateTimeKind.Local).AddTicks(1918));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionLine",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 14, 15, 7, 28, 609, DateTimeKind.Local).AddTicks(7697),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 14, 15, 13, 26, 585, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Decomposition",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 14, 15, 7, 28, 609, DateTimeKind.Local).AddTicks(5653),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 14, 15, 13, 26, 585, DateTimeKind.Local).AddTicks(7090));
        }
    }
}
