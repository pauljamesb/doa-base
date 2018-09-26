﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DOA.Data.Migrations
{
    public partial class CanonBallRunII : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AllDaysFromDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Distance = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    URLLink = table.Column<string>(nullable: true),
                    URLText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllDaysFromDb", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllDaysFromDb");
        }
    }
}
