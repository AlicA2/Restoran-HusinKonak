using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HusinKonak.Data.Migrations
{
    /// <inheritdoc />
    public partial class RezervacijaAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImePrezime",
                table: "Rezervacija",
                newName: "Prezime");

            migrationBuilder.RenameColumn(
                name: "BrojStola",
                table: "Rezervacija",
                newName: "Ime");

            migrationBuilder.AddColumn<string>(
                name: "BrojOsoba",
                table: "Rezervacija",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Vrijeme",
                table: "Rezervacija",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrojOsoba",
                table: "Rezervacija");

            migrationBuilder.DropColumn(
                name: "Vrijeme",
                table: "Rezervacija");

            migrationBuilder.RenameColumn(
                name: "Prezime",
                table: "Rezervacija",
                newName: "ImePrezime");

            migrationBuilder.RenameColumn(
                name: "Ime",
                table: "Rezervacija",
                newName: "BrojStola");
        }
    }
}
