using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HusinKonak.Data.Migrations
{
    /// <inheritdoc />
    public partial class novamigracijazaMeni : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "slika",
                table: "Meni",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "slika",
                table: "Meni");
        }
    }
}
