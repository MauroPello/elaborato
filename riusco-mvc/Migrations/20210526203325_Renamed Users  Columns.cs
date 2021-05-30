using Microsoft.EntityFrameworkCore.Migrations;

namespace riusco_mvc.Migrations
{
    public partial class RenamedUsersColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Users",
                newName: "City");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "City",
                table: "Users",
                newName: "Address");
        }
    }
}
