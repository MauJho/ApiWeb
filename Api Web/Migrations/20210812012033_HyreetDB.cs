using Microsoft.EntityFrameworkCore.Migrations;

namespace Api_Web.Migrations
{
    public partial class HyreetDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentEmployeeId",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentsDepartmentEmployeeId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentEmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Departments = table.Column<string>(nullable: true),
                    Division = table.Column<string>(nullable: true),
                    Workstream = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentEmployeeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_DepartmentsDepartmentEmployeeId",
                table: "Users",
                column: "DepartmentsDepartmentEmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Departments_DepartmentsDepartmentEmployeeId",
                table: "Users",
                column: "DepartmentsDepartmentEmployeeId",
                principalTable: "Departments",
                principalColumn: "DepartmentEmployeeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Departments_DepartmentsDepartmentEmployeeId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Users_DepartmentsDepartmentEmployeeId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DepartmentEmployeeId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DepartmentsDepartmentEmployeeId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Users");
        }
    }
}
