using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HusinKonak.Data.Migrations
{
    /// <inheritdoc />
    public partial class testiranje : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DostavaId",
                table: "Meni",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BrojTelefona",
                table: "Dostava",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Meni_DostavaId",
                table: "Meni",
                column: "DostavaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meni_Dostava_DostavaId",
                table: "Meni",
                column: "DostavaId",
                principalTable: "Dostava",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meni_Dostava_DostavaId",
                table: "Meni");

            migrationBuilder.DropIndex(
                name: "IX_Meni_DostavaId",
                table: "Meni");

            migrationBuilder.DropColumn(
                name: "DostavaId",
                table: "Meni");

            migrationBuilder.DropColumn(
                name: "BrojTelefona",
                table: "Dostava");
        }
    }
}
