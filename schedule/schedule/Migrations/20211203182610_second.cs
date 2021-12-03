using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace schedule.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d297b366-b063-4ebf-b6c2-4d2a2c4a20d6",
                column: "ConcurrencyStamp",
                value: "66cec686-5593-4778-9609-af119a193abc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8bed4de-81b4-4ece-86bc-d84bf1b9e98b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "647479dc-bbaa-4576-97f4-b546b637fafe", "AQAAAAEAACcQAAAAEGXogH51ee51U8BIFMGv50FcM273Y7c8Za4ytErzbTysXuUQAIg7tbiHX61EGEVu/Q==" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("1e23063e-2fb8-4a89-88b5-d64276fdd3d8"),
                column: "numCourse",
                value: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d297b366-b063-4ebf-b6c2-4d2a2c4a20d6",
                column: "ConcurrencyStamp",
                value: "53d16ab4-57ba-46dd-869b-eae6a1a797dd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8bed4de-81b4-4ece-86bc-d84bf1b9e98b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1fd19501-749c-4a60-91ca-9fc1746d5d7d", "AQAAAAEAACcQAAAAEGk8LjK5xWdt2gF4hbKKiXsfH2Zch9WHCnjZdNkjLuEb3fyUOgzISHumNU61mo04tw==" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("1e23063e-2fb8-4a89-88b5-d64276fdd3d8"),
                column: "numCourse",
                value: 2);
        }
    }
}
