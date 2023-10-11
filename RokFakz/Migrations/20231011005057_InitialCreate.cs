using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RokFakz.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RokFak",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Rock = table.Column<string>(type: "TEXT", nullable: true),
                    MohsHardness = table.Column<decimal>(type: "TEXT", nullable: false),
                    Density = table.Column<decimal>(type: "TEXT", nullable: false),
                    Texture = table.Column<string>(type: "TEXT", nullable: true),
                    Color = table.Column<string>(type: "TEXT", nullable: true),
                    Fak = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RokFak", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RokFak");
        }
    }
}
