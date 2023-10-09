using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HusinKonak.Data.Migrations
{
    /// <inheritdoc />
    public partial class KategorijaAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "slika",
                table: "Meni");

            migrationBuilder.AddColumn<int>(
                name: "KategorijaId",
                table: "Meni",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Kategorija",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorija", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meni_Kategorija_KategorijaId",
                table: "Meni");

            migrationBuilder.DropTable(
                name: "Kategorija");

            migrationBuilder.DropIndex(
                name: "IX_Meni_KategorijaId",
                table: "Meni");

            migrationBuilder.DropColumn(
                name: "KategorijaId",
                table: "Meni");

            migrationBuilder.AddColumn<byte[]>(
                name: "slika",
                table: "Meni",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
