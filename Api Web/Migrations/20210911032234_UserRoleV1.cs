using Microsoft.EntityFrameworkCore.Migrations;

namespace Api_Web.Migrations
{
    public partial class UserRoleV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "UserRoles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "UserRoles",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
