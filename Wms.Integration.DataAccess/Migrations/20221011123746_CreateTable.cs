using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wms.Integration.DataAccess.Migrations
{
    public partial class CreateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DecompositionShelf",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    Description = table.Column<string>(type: "NVarChar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "DateTime", nullable: false, defaultValue: new DateTime(2022, 10, 11, 15, 37, 45, 608, DateTimeKind.Local).AddTicks(9947)),
                    CreatedBy = table.Column<int>(type: "Int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ModifiedBy = table.Column<int>(type: "Int", nullable: false),
                    Capacity = table.Column<int>(type: "Int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DecompositionShelf", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Decomposition",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime", nullable: false, defaultValue: new DateTime(2022, 10, 11, 15, 37, 45, 608, DateTimeKind.Local).AddTicks(2343)),
                    CreatedBy = table.Column<int>(type: "Int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ModifiedBy = table.Column<int>(type: "Int", nullable: false),
                    DecompositionShelfId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    IsCompleted = table.Column<bool>(type: "Bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decomposition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Decomposition_DecompositionShelf_DecompositionShelfId",
                        column: x => x.DecompositionShelfId,
                        principalTable: "DecompositionShelf",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DecompositionShelves",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime", nullable: false, defaultValue: new DateTime(2022, 10, 11, 15, 37, 45, 609, DateTimeKind.Local).AddTicks(1271)),
                    CreatedBy = table.Column<int>(type: "Int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ModifiedBy = table.Column<int>(type: "Int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "NVarChar(250)", maxLength: 250, nullable: true),
                    DecompositionShelfId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DecompositionShelves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DecompositionShelves_DecompositionShelf_DecompositionShelfId",
                        column: x => x.DecompositionShelfId,
                        principalTable: "DecompositionShelf",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DecompositionLine",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime", nullable: false, defaultValue: new DateTime(2022, 10, 11, 15, 37, 45, 608, DateTimeKind.Local).AddTicks(6131)),
                    CreatedBy = table.Column<int>(type: "Int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ModifiedBy = table.Column<int>(type: "Int", nullable: false),
                    Amount = table.Column<int>(type: "Int", nullable: false),
                    SlipLineId = table.Column<int>(type: "Int", nullable: false),
                    DecompositionShelvesId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DecompositionLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DecompositionLine_DecompositionShelves_DecompositionShelvesId",
                        column: x => x.DecompositionShelvesId,
                        principalTable: "DecompositionShelves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DecompositionLine_OrderSlipLine_SlipLineId",
                        column: x => x.SlipLineId,
                        principalTable: "OrderSlipLine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Decomposition_DecompositionShelfId",
                table: "Decomposition",
                column: "DecompositionShelfId");

            migrationBuilder.CreateIndex(
                name: "IX_DecompositionLine_DecompositionShelvesId",
                table: "DecompositionLine",
                column: "DecompositionShelvesId");

            migrationBuilder.CreateIndex(
                name: "IX_DecompositionLine_SlipLineId",
                table: "DecompositionLine",
                column: "SlipLineId");

            migrationBuilder.CreateIndex(
                name: "IX_DecompositionShelves_DecompositionShelfId",
                table: "DecompositionShelves",
                column: "DecompositionShelfId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Decomposition");

            migrationBuilder.DropTable(
                name: "DecompositionLine");

            migrationBuilder.DropTable(
                name: "DecompositionShelves");

            migrationBuilder.DropTable(
                name: "DecompositionShelf");
        }
    }
}
