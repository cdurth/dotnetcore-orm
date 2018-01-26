using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApplication1.Migrations
{
    public partial class Theaters3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Theater_Movie_MovieID",
                table: "Theater");

            migrationBuilder.DropIndex(
                name: "IX_Theater_MovieID",
                table: "Theater");

            migrationBuilder.DropColumn(
                name: "MovieID",
                table: "Theater");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Theater",
                newName: "TheaterID");

            migrationBuilder.CreateTable(
                name: "MovieTheaterLink",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false),
                    TheaterID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieTheaterLink", x => new { x.MovieID, x.TheaterID });
                    table.ForeignKey(
                        name: "FK_MovieTheaterLink_Movie_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movie",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieTheaterLink_Theater_TheaterID",
                        column: x => x.TheaterID,
                        principalTable: "Theater",
                        principalColumn: "TheaterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieTheaterLink_TheaterID",
                table: "MovieTheaterLink",
                column: "TheaterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieTheaterLink");

            migrationBuilder.RenameColumn(
                name: "TheaterID",
                table: "Theater",
                newName: "ID");

            migrationBuilder.AddColumn<int>(
                name: "MovieID",
                table: "Theater",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Theater_MovieID",
                table: "Theater",
                column: "MovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_Theater_Movie_MovieID",
                table: "Theater",
                column: "MovieID",
                principalTable: "Movie",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
