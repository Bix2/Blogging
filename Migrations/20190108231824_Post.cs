using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blogging.Migrations
{
    public partial class Post : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "posts",
                columns: new[] { "PostId", "AuthorId", "Content", "Date", "Title" },
                values: new object[] { 1, 2, "Shakespeare", new DateTime(2019, 1, 9, 0, 18, 23, 419, DateTimeKind.Local), "William" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "posts",
                keyColumn: "PostId",
                keyValue: 1);
        }
    }
}
