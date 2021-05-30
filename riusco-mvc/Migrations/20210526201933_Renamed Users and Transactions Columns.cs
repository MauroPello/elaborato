using Microsoft.EntityFrameworkCore.Migrations;

namespace riusco_mvc.Migrations
{
    public partial class RenamedUsersandTransactionsColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Users_SellerID",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "UserImage",
                table: "Users",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CoinAmount",
                table: "Users",
                newName: "Balance");

            migrationBuilder.RenameColumn(
                name: "SellerID",
                table: "Transactions",
                newName: "OwnerID");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_SellerID",
                table: "Transactions",
                newName: "IX_Transactions_OwnerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Users_OwnerID",
                table: "Transactions",
                column: "OwnerID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Users_OwnerID",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Users",
                newName: "UserImage");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "Balance",
                table: "Users",
                newName: "CoinAmount");

            migrationBuilder.RenameColumn(
                name: "OwnerID",
                table: "Transactions",
                newName: "SellerID");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_OwnerID",
                table: "Transactions",
                newName: "IX_Transactions_SellerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Users_SellerID",
                table: "Transactions",
                column: "SellerID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
