using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProjectGroup3.Migrations
{
    /// <inheritdoc />
    public partial class SeedAllTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "Age", "FurColor", "HasAutoFeeder", "Name" },
                values: new object[,]
                {
                    { 1, 3, "Orange", true, "Whiskers" },
                    { 2, 5, "Black", false, "Luna" },
                    { 3, 1, "Gray", true, "Milo" }
                });

            migrationBuilder.InsertData(
                table: "TeamMemberData",
                columns: new[] { "Id", "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[,]
                {
                    { 1, new DateTime(2003, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology", "Sample Student One", 3 },
                    { 2, new DateTime(2002, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Computer Science", "Sample Student Two", 4 }
                });

            migrationBuilder.InsertData(
                table: "TravelDestinations",
                columns: new[] { "Id", "BestSeasonToVisit", "Country", "Description", "DestinationName", "Rating" },
                values: new object[,]
                {
                    { 1, "Spring", "Japan", "Historic temples, gardens, and traditional tea houses.", "Kyoto", 5 },
                    { 2, "Summer", "Greece", "Whitewashed cliffside villages overlooking the Aegean Sea.", "Santorini", 5 },
                    { 3, "Fall", "Canada", "Turquoise lakes surrounded by the Canadian Rockies.", "Banff", 4 }
                });

            migrationBuilder.InsertData(
                table: "VideoGames",
                columns: new[] { "Id", "Engine", "IsMultiplayer", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 1, "Proprietary", false, 2017, "The Legend of Zelda: Breath of the Wild" },
                    { 2, "Unreal Engine", true, 2017, "Fortnite" },
                    { 3, "MonoGame", true, 2016, "Stardew Valley" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TeamMemberData",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TeamMemberData",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TravelDestinations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TravelDestinations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TravelDestinations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
