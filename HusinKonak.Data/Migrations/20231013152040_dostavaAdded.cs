using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HusinKonak.Data.Migrations
{
    /// <inheritdoc />
    public partial class dostavaAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dostava",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cijena = table.Column<float>(type: "real", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    korisnik_id = table.Column<int>(type: "int", nullable: true),
                    meni_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dostava", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dostava_Korisnik_korisnik_id",
                        column: x => x.korisnik_id,
                        principalTable: "Korisnik",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Dostava_Meni_meni_id",
                        column: x => x.meni_id,
                        principalTable: "Meni",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dostava_korisnik_id",
                table: "Dostava",
                column: "korisnik_id");

            migrationBuilder.CreateIndex(
                name: "IX_Dostava_meni_id",
                table: "Dostava",
                column: "meni_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dostava");
        }
    }
}
