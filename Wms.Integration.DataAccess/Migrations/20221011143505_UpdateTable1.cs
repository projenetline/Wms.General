using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wms.Integration.DataAccess.Migrations
{
    public partial class UpdateTable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionShelves",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 11, 17, 35, 5, 185, DateTimeKind.Local).AddTicks(5236),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 11, 15, 37, 45, 609, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionShelf",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 11, 17, 35, 5, 185, DateTimeKind.Local).AddTicks(4530),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 11, 15, 37, 45, 608, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionLine",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 11, 17, 35, 5, 185, DateTimeKind.Local).AddTicks(2306),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 11, 15, 37, 45, 608, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Decomposition",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 11, 17, 35, 5, 185, DateTimeKind.Local).AddTicks(234),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 11, 15, 37, 45, 608, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.CreateTable(
                name: "Logger",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    MethodName = table.Column<string>(type: "NVarChar(250)", maxLength: 250, nullable: true),
                    ProjectName = table.Column<string>(type: "NVarChar(250)", maxLength: 250, nullable: true),
                    Message1 = table.Column<string>(type: "NVarChar(250)", maxLength: 250, nullable: true),
                    Message2 = table.Column<string>(type: "NVarChar(250)", maxLength: 250, nullable: true),
                    Statu = table.Column<string>(type: "NVarChar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logger", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logger");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionShelves",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 11, 15, 37, 45, 609, DateTimeKind.Local).AddTicks(1271),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 11, 17, 35, 5, 185, DateTimeKind.Local).AddTicks(5236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionShelf",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 11, 15, 37, 45, 608, DateTimeKind.Local).AddTicks(9947),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 11, 17, 35, 5, 185, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionLine",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 11, 15, 37, 45, 608, DateTimeKind.Local).AddTicks(6131),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 11, 17, 35, 5, 185, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Decomposition",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 11, 15, 37, 45, 608, DateTimeKind.Local).AddTicks(2343),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 11, 17, 35, 5, 185, DateTimeKind.Local).AddTicks(234));
        }
    }
}
