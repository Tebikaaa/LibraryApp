using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryEFCore.Migrations
{
    /// <inheritdoc />
    public partial class newTablesNewSystem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Uyarilar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UyeID = table.Column<int>(type: "INTEGER", nullable: false),
                    Tipi = table.Column<int>(type: "INTEGER", nullable: false),
                    UyariMesaji = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    UyariTarihi = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uyarilar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Uyarilar_Uyeler_UyeID",
                        column: x => x.UyeID,
                        principalTable: "Uyeler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Uyarilar_UyeID",
                table: "Uyarilar",
                column: "UyeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Uyarilar");
        }
    }
}
