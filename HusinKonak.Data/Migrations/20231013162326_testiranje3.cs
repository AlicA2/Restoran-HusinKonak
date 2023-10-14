using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HusinKonak.Data.Migrations
{
    /// <inheritdoc />
    public partial class testiranje3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DostavaMeni");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DostavaMeni",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DostavaId = table.Column<int>(type: "int", nullable: false),
                    MeniId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DostavaMeni", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DostavaMeni_Dostava_DostavaId",
                        column: x => x.DostavaId,
                        principalTable: "Dostava",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DostavaMeni_Meni_MeniId",
                        column: x => x.MeniId,
                        principalTable: "Meni",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DostavaMeni_DostavaId",
                table: "DostavaMeni",
                column: "DostavaId");

            migrationBuilder.CreateIndex(
                name: "IX_DostavaMeni_MeniId",
                table: "DostavaMeni",
                column: "MeniId");
        }
    }
}
