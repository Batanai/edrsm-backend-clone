using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactCenter.Data.Migrations
{
    public partial class AddExtraFieldsToPaymentPlanTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ApprovalStatus",
                table: "RequestedPaymentPlans",
                newName: "ReviewStatus");

            migrationBuilder.AddColumn<bool>(
                name: "AgreeToTermsAndConditions",
                table: "RequestedPaymentPlans",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ReviewComment",
                table: "RequestedPaymentPlans",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgreeToTermsAndConditions",
                table: "RequestedPaymentPlans");

            migrationBuilder.DropColumn(
                name: "ReviewComment",
                table: "RequestedPaymentPlans");

            migrationBuilder.RenameColumn(
                name: "ReviewStatus",
                table: "RequestedPaymentPlans",
                newName: "ApprovalStatus");
        }
    }
}
