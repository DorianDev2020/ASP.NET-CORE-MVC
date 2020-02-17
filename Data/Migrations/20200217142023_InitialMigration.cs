using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperHeroProject.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Heroname = table.Column<string>(nullable: true),
                    Herorealname = table.Column<string>(nullable: true),
                    Heroprimarypower = table.Column<string>(nullable: true),
                    Herosecondarypower = table.Column<string>(nullable: true),
                    catchphrase = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Heroes");
        }
    }
}
