using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApplication1.Migrations
{
    public partial class Theaters1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Theater_TheaterID",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_TheaterID",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "TheaterID",
                table: "Movie");

            migrationBuilder.AddColumn<int>(
                name: "MovieID",
                table: "Theater",
                nullable: true);

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
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "TheaterID",
                table: "Movie",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movie_TheaterID",
                table: "Movie",
                column: "TheaterID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Theater_TheaterID",
                table: "Movie",
                column: "TheaterID",
                principalTable: "Theater",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
