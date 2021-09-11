using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthSystem.Infra.Migrations
{
    public partial class InsertingDefaultUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { new Guid("64c67611-ed03-4fa7-887d-a9a46e6b7acd"), "userdefault@auth.com", "User Default" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("64c67611-ed03-4fa7-887d-a9a46e6b7acd"));
        }
    }
}
