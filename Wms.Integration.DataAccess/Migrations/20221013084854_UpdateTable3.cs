using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wms.Integration.DataAccess.Migrations
{
    public partial class UpdateTable3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Logger",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionShelves",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 13, 11, 48, 54, 103, DateTimeKind.Local).AddTicks(3567),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 11, 17, 59, 8, 50, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionShelf",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 13, 11, 48, 54, 103, DateTimeKind.Local).AddTicks(2752),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 11, 17, 59, 8, 50, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionLine",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 13, 11, 48, 54, 103, DateTimeKind.Local).AddTicks(122),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 11, 17, 59, 8, 50, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Decomposition",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 13, 11, 48, 54, 102, DateTimeKind.Local).AddTicks(7673),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 11, 17, 59, 8, 49, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "Int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "NVarChar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "Int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "NVarChar", nullable: true),
                    LastName = table.Column<string>(type: "NVarChar", nullable: true),
                    UserName = table.Column<string>(type: "NVarChar", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "VarBinary", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "VarBinary", nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "Int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "Int", nullable: false),
                    OperationClaimId = table.Column<int>(type: "Int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserOperationClaims_OperationClaims_OperationClaimId",
                        column: x => x.OperationClaimId,
                        principalTable: "OperationClaims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserOperationClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClaims_OperationClaimId",
                table: "UserOperationClaims",
                column: "OperationClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClaims_UserId",
                table: "UserOperationClaims",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Logger");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionShelves",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 11, 17, 59, 8, 50, DateTimeKind.Local).AddTicks(4066),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 13, 11, 48, 54, 103, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionShelf",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 11, 17, 59, 8, 50, DateTimeKind.Local).AddTicks(3349),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 13, 11, 48, 54, 103, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DecompositionLine",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 11, 17, 59, 8, 50, DateTimeKind.Local).AddTicks(1078),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 13, 11, 48, 54, 103, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Decomposition",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 11, 17, 59, 8, 49, DateTimeKind.Local).AddTicks(8838),
                oldClrType: typeof(DateTime),
                oldType: "DateTime",
                oldDefaultValue: new DateTime(2022, 10, 13, 11, 48, 54, 102, DateTimeKind.Local).AddTicks(7673));
        }
    }
}
