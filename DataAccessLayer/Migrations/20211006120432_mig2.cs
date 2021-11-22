using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyFK",
                table: "SurveyReleases");

            migrationBuilder.DropColumn(
                name: "CompanyFK",
                table: "SurveyDesigns");

            migrationBuilder.DropColumn(
                name: "CompanyFK",
                table: "SISServices");

            migrationBuilder.DropColumn(
                name: "CompanyFK",
                table: "RoomTypes");

            migrationBuilder.DropColumn(
                name: "CompanyFK",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "CompanyFK",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "CompanyFK",
                table: "RoleAuthorizations");

            migrationBuilder.DropColumn(
                name: "CompanyFK",
                table: "PreventiveActivities");

            migrationBuilder.DropColumn(
                name: "CompanyFK",
                table: "Periods");

            migrationBuilder.DropColumn(
                name: "CompanyFK",
                table: "MembershipPackages");

            migrationBuilder.DropColumn(
                name: "CompanyFK",
                table: "LocationAuthorizations");

            migrationBuilder.DropColumn(
                name: "CompanyFK",
                table: "InspectionUnsuitabilities");

            migrationBuilder.DropColumn(
                name: "CompanyFK",
                table: "InspectionSets");

            migrationBuilder.DropColumn(
                name: "CompanyFK",
                table: "InspectionSetQuestions");

            migrationBuilder.DropColumn(
                name: "CompanyFK",
                table: "ImportanceLevels");

            migrationBuilder.DropColumn(
                name: "CompanyFK",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "CompanyFK",
                table: "FacilityTypes");

            migrationBuilder.DropColumn(
                name: "CompanyFK",
                table: "FacilityService");

            migrationBuilder.DropColumn(
                name: "CompanyFK",
                table: "Facilities");

            migrationBuilder.DropColumn(
                name: "CompanyFK",
                table: "Blocks");

            migrationBuilder.DropColumn(
                name: "CompanyFK",
                table: "Audits");

            migrationBuilder.DropColumn(
                name: "CompanyFK",
                table: "AuditAnswers");

            migrationBuilder.DropColumn(
                name: "CompanyFK",
                table: "AnswerSets");

            migrationBuilder.DropColumn(
                name: "CompanyFK",
                table: "AnswerSetDetails");

            migrationBuilder.DropColumn(
                name: "CompanyFK",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "CompanyFK",
                table: "AccountRoles");

            migrationBuilder.DropColumn(
                name: "CompanyFK",
                table: "AccountRoleAuthorizations");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Companies",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Companies",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccountPhoneNumber",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountPhoneNumber",
                table: "Accounts");

            migrationBuilder.AddColumn<int>(
                name: "CompanyFK",
                table: "SurveyReleases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyFK",
                table: "SurveyDesigns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyFK",
                table: "SISServices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyFK",
                table: "RoomTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyFK",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyFK",
                table: "Roles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyFK",
                table: "RoleAuthorizations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyFK",
                table: "PreventiveActivities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyFK",
                table: "Periods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyFK",
                table: "MembershipPackages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyFK",
                table: "LocationAuthorizations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyFK",
                table: "InspectionUnsuitabilities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyFK",
                table: "InspectionSets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyFK",
                table: "InspectionSetQuestions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyFK",
                table: "ImportanceLevels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyFK",
                table: "Floors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyFK",
                table: "FacilityTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyFK",
                table: "FacilityService",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyFK",
                table: "Facilities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyFK",
                table: "Blocks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyFK",
                table: "Audits",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyFK",
                table: "AuditAnswers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyFK",
                table: "AnswerSets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyFK",
                table: "AnswerSetDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyFK",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyFK",
                table: "AccountRoles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyFK",
                table: "AccountRoleAuthorizations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
