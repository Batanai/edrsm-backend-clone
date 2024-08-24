using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactCenter.Data.Migrations
{
    public partial class AddExtraFieldsToPaymentPlanAndIncidentAuditTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdminReviewerId",
                table: "RequestedPaymentPlans",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdminReviewerName",
                table: "RequestedPaymentPlans",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdminReviewerSurname",
                table: "RequestedPaymentPlans",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RequestPostedDate",
                table: "RequestedPaymentPlans",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "RequestReviewedDate",
                table: "RequestedPaymentPlans",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "NameOfUpdater",
                table: "IncidentAudit",
                type: "character varying(128)",
                maxLength: 128,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SurnameOfUpdater",
                table: "IncidentAudit",
                type: "character varying(128)",
                maxLength: 128,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdminReviewerId",
                table: "RequestedPaymentPlans");

            migrationBuilder.DropColumn(
                name: "AdminReviewerName",
                table: "RequestedPaymentPlans");

            migrationBuilder.DropColumn(
                name: "AdminReviewerSurname",
                table: "RequestedPaymentPlans");

            migrationBuilder.DropColumn(
                name: "RequestPostedDate",
                table: "RequestedPaymentPlans");

            migrationBuilder.DropColumn(
                name: "RequestReviewedDate",
                table: "RequestedPaymentPlans");

            migrationBuilder.DropColumn(
                name: "NameOfUpdater",
                table: "IncidentAudit");

            migrationBuilder.DropColumn(
                name: "SurnameOfUpdater",
                table: "IncidentAudit");
        }
    }
}
