using Microsoft.EntityFrameworkCore.Migrations;

namespace riusco_mvc.Migrations
{
    public partial class RenamedClientSecretToApiKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClientSecret",
                table: "Users",
                newName: "ApiKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ApiKey",
                table: "Users",
                newName: "ClientSecret");
        }
    }
}
