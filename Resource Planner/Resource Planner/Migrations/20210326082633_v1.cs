using Microsoft.EntityFrameworkCore.Migrations;

namespace Resource_Planner.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Persons",
                newName: "Types");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Types",
                table: "Persons",
                newName: "Type");
        }
    }
}
