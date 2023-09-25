using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HusinKonak.Data.Migrations
{
    /// <inheritdoc />
    public partial class treca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kontakt_KorisnickiNalog_korisnickiNalogID",
                table: "Kontakt");

            migrationBuilder.RenameColumn(
                name: "korisnickiNalogID",
                table: "Kontakt",
                newName: "korisnikID");

            migrationBuilder.RenameIndex(
                name: "IX_Kontakt_korisnickiNalogID",
                table: "Kontakt",
                newName: "IX_Kontakt_korisnikID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kontakt_Korisnik_korisnikID",
                table: "Kontakt",
                column: "korisnikID",
                principalTable: "Korisnik",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kontakt_Korisnik_korisnikID",
                table: "Kontakt");

            migrationBuilder.RenameColumn(
                name: "korisnikID",
                table: "Kontakt",
                newName: "korisnickiNalogID");

            migrationBuilder.RenameIndex(
                name: "IX_Kontakt_korisnikID",
                table: "Kontakt",
                newName: "IX_Kontakt_korisnickiNalogID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kontakt_KorisnickiNalog_korisnickiNalogID",
                table: "Kontakt",
                column: "korisnickiNalogID",
                principalTable: "KorisnickiNalog",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
