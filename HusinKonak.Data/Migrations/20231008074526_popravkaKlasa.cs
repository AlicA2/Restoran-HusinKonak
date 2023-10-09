using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HusinKonak.Data.Migrations
{
    /// <inheritdoc />
    public partial class popravkaKlasa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meni_Kategorija_KategorijaId",
                table: "Meni");

            migrationBuilder.DropIndex(
                name: "IX_Meni_KategorijaId",
                table: "Meni");

            migrationBuilder.DropColumn(
                name: "KategorijaId",
                table: "Meni");

            migrationBuilder.AddColumn<int>(
                name: "MeniId",
                table: "Kategorija",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kategorija_MeniId",
                table: "Kategorija",
                column: "MeniId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kategorija_Meni_MeniId",
                table: "Kategorija",
                column: "MeniId",
                principalTable: "Meni",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kategorija_Meni_MeniId",
                table: "Kategorija");

            migrationBuilder.DropIndex(
                name: "IX_Kategorija_MeniId",
                table: "Kategorija");

            migrationBuilder.DropColumn(
                name: "MeniId",
                table: "Kategorija");

            migrationBuilder.AddColumn<int>(
                name: "KategorijaId",
                table: "Meni",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Meni_KategorijaId",
                table: "Meni",
                column: "KategorijaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meni_Kategorija_KategorijaId",
                table: "Meni",
                column: "KategorijaId",
                principalTable: "Kategorija",
                principalColumn: "Id");
        }
    }
}
