using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryEFCore.Migrations
{
    /// <inheritdoc />
    public partial class AddSeriNoTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeriNo",
                table: "Kitaplar");

            migrationBuilder.CreateTable(
                name: "SeriNolar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SeriNoKodu = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    KitapID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeriNolar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SeriNolar_Kitaplar_KitapID",
                        column: x => x.KitapID,
                        principalTable: "Kitaplar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SeriNolar_KitapID",
                table: "SeriNolar",
                column: "KitapID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SeriNolar");

            migrationBuilder.AddColumn<string>(
                name: "SeriNo",
                table: "Kitaplar",
                type: "TEXT",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }
    }
}
