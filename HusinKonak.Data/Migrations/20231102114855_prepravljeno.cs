using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HusinKonak.Data.Migrations
{
    /// <inheritdoc />
    public partial class prepravljeno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Rezervacija",
                table: "Rezervacija");

            migrationBuilder.RenameTable(
                name: "Rezervacija",
                newName: "Rezervacije");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rezervacije",
                table: "Rezervacije",
                column: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Rezervacije",
                table: "Rezervacije");

            migrationBuilder.RenameTable(
                name: "Rezervacije",
                newName: "Rezervacija");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rezervacija",
                table: "Rezervacija",
                column: "ID");
        }
    }
}
