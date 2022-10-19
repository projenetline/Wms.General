using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wms.Integration.DataAccess.Migrations
{
    public partial class UpdateTable4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionShelves",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 14, 15, 7, 28, 610, DateTimeKind.Local).AddTicks(607),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 13, 11, 48, 54, 103, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionShelf",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 14, 15, 7, 28, 609, DateTimeKind.Local).AddTicks(9926),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 13, 11, 48, 54, 103, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionLine",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 14, 15, 7, 28, 609, DateTimeKind.Local).AddTicks(7697),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 13, 11, 48, 54, 103, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Decomposition",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 14, 15, 7, 28, 609, DateTimeKind.Local).AddTicks(5653),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 13, 11, 48, 54, 102, DateTimeKind.Local).AddTicks(7673));

        
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionShelves",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 13, 11, 48, 54, 103, DateTimeKind.Local).AddTicks(3567),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 14, 15, 7, 28, 610, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionShelf",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 13, 11, 48, 54, 103, DateTimeKind.Local).AddTicks(2752),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 14, 15, 7, 28, 609, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionLine",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 13, 11, 48, 54, 103, DateTimeKind.Local).AddTicks(122),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 14, 15, 7, 28, 609, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Decomposition",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 13, 11, 48, 54, 102, DateTimeKind.Local).AddTicks(7673),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 14, 15, 7, 28, 609, DateTimeKind.Local).AddTicks(5653));
        }
    }
}
