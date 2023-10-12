using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HusinKonak.Data.Migrations
{
    /// <inheritdoc />
    public partial class test3 : Migration
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
                    KorisnikId = table.Column<int>(type: "int", nullable: false),
                    DatumNarudzbe = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdresaDostave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UkupnaCijena = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dostava", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dostava_Korisnik_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetaljiDostave",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeniId = table.Column<int>(type: "int", nullable: false),
                    DostavaId = table.Column<int>(type: "int", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false),
                    CijenaPoStavci = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetaljiDostave", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetaljiDostave_Dostava_DostavaId",
                        column: x => x.DostavaId,
                        principalTable: "Dostava",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetaljiDostave_Meni_MeniId",
                        column: x => x.MeniId,
                        principalTable: "Meni",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetaljiDostave_DostavaId",
                table: "DetaljiDostave",
                column: "DostavaId");

            migrationBuilder.CreateIndex(
                name: "IX_DetaljiDostave_MeniId",
                table: "DetaljiDostave",
                column: "MeniId");

            migrationBuilder.CreateIndex(
                name: "IX_Dostava_KorisnikId",
                table: "Dostava",
                column: "KorisnikId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetaljiDostave");

            migrationBuilder.DropTable(
                name: "Dostava");
        }
    }
}
