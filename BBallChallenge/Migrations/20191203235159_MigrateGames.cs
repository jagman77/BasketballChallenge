using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BBallChallenge.Migrations
{
    public partial class MigrateGames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameTime = table.Column<DateTime>(nullable: false),
                    GameDate = table.Column<DateTime>(nullable: false),
                    Venue = table.Column<string>(nullable: true),
                    Payee = table.Column<string>(nullable: true),
                    AmountPaid = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Game");
        }
    }
}
