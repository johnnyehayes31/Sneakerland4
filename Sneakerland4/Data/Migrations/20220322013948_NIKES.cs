using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sneakerland4.Data.Migrations
{
    public partial class NIKES : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nike",
                columns: table => new
                {
                    NikeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NikeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NikeClothing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NikeShoes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nike", x => x.NikeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nike");
        }
    }
}
