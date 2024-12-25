using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryEFCore.Migrations
{
    /// <inheritdoc />
    public partial class uyeStatuAndUyeCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UyeCreated",
                table: "Uyeler",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "UyeStatus",
                table: "Uyeler",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UyeCreated",
                table: "Uyeler");

            migrationBuilder.DropColumn(
                name: "UyeStatus",
                table: "Uyeler");
        }
    }
}
