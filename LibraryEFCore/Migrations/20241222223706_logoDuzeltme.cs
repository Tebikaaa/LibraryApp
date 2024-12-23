using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryEFCore.Migrations
{
    /// <inheritdoc />
    public partial class logoDuzeltme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OduncAlmaTipi",
                table: "OduncIslemleri",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Durum",
                table: "Kitaplar",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OduncAlmaTipi",
                table: "OduncIslemleri");

            migrationBuilder.DropColumn(
                name: "Durum",
                table: "Kitaplar");
        }
    }
}
