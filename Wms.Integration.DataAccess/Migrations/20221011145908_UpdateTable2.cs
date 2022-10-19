using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wms.Integration.DataAccess.Migrations
{
    public partial class UpdateTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionShelves",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 11, 17, 59, 8, 50, DateTimeKind.Local).AddTicks(4066),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 11, 17, 35, 5, 185, DateTimeKind.Local).AddTicks(5236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionShelf",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 11, 17, 59, 8, 50, DateTimeKind.Local).AddTicks(3349),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 11, 17, 35, 5, 185, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionLine",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 11, 17, 59, 8, 50, DateTimeKind.Local).AddTicks(1078),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 11, 17, 35, 5, 185, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Decomposition",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 11, 17, 59, 8, 49, DateTimeKind.Local).AddTicks(8838),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 11, 17, 35, 5, 185, DateTimeKind.Local).AddTicks(234));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionShelves",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 11, 17, 35, 5, 185, DateTimeKind.Local).AddTicks(5236),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 11, 17, 59, 8, 50, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionShelf",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 11, 17, 35, 5, 185, DateTimeKind.Local).AddTicks(4530),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 11, 17, 59, 8, 50, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionLine",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 11, 17, 35, 5, 185, DateTimeKind.Local).AddTicks(2306),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 11, 17, 59, 8, 50, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Decomposition",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 11, 17, 35, 5, 185, DateTimeKind.Local).AddTicks(234),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 11, 17, 59, 8, 49, DateTimeKind.Local).AddTicks(8838));
        }
    }
}
