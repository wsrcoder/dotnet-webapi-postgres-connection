using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_webapi_postgres_example.Migrations
{
    public partial class UserModification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "TUser");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TUser",
                newName: "Val_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TUser",
                table: "TUser",
                column: "Val_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TUser",
                table: "TUser");

            migrationBuilder.RenameTable(
                name: "TUser",
                newName: "Users");

            migrationBuilder.RenameColumn(
                name: "Val_ID",
                table: "Users",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");
        }
    }
}
