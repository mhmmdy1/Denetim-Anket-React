using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Companies_CompanyId",
                table: "Accounts");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Accounts",
                newName: "CompanyId1");

            migrationBuilder.RenameIndex(
                name: "IX_Accounts_CompanyId",
                table: "Accounts",
                newName: "IX_Accounts_CompanyId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Companies_CompanyId1",
                table: "Accounts",
                column: "CompanyId1",
                principalTable: "Companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Companies_CompanyId1",
                table: "Accounts");

            migrationBuilder.RenameColumn(
                name: "CompanyId1",
                table: "Accounts",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Accounts_CompanyId1",
                table: "Accounts",
                newName: "IX_Accounts_CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Companies_CompanyId",
                table: "Accounts",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
