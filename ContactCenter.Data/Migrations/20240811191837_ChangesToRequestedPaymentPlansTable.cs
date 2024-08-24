using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactCenter.Data.Migrations
{
    public partial class ChangesToRequestedPaymentPlansTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "RequestedPaymentPlans _AdminID _fkey",
                table: "RequestedPaymentPlans ");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RequestedPaymentPlans ",
                table: "RequestedPaymentPlans ");

            migrationBuilder.DropColumn(
                name: "Amount ",
                table: "RequestedPaymentPlans ");

            migrationBuilder.DropColumn(
                name: "Duration ",
                table: "RequestedPaymentPlans ");

            migrationBuilder.DropColumn(
                name: "SelectedPlan ",
                table: "RequestedPaymentPlans ");

            migrationBuilder.DropColumn(
                name: "Status ",
                table: "RequestedPaymentPlans ");

            migrationBuilder.DropColumn(
                name: "TermsAndConditions ",
                table: "RequestedPaymentPlans ");

            migrationBuilder.RenameTable(
                name: "RequestedPaymentPlans ",
                newName: "RequestedPaymentPlans");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "RequestedPaymentPlans",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "AdminID ",
                table: "RequestedPaymentPlans",
                newName: "AdminId");

            migrationBuilder.RenameIndex(
                name: "IX_RequestedPaymentPlans _AdminID ",
                table: "RequestedPaymentPlans",
                newName: "IX_RequestedPaymentPlans_AdminId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "RequestedPaymentPlans",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying");

            migrationBuilder.AlterColumn<Guid>(
                name: "AdminId",
                table: "RequestedPaymentPlans",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<decimal>(
                name: "AmountDue",
                table: "RequestedPaymentPlans",
                type: "numeric(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "AmountPaidDown",
                table: "RequestedPaymentPlans",
                type: "numeric(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationReference",
                table: "RequestedPaymentPlans",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApprovalStatus",
                table: "RequestedPaymentPlans",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CellphoneNumber",
                table: "RequestedPaymentPlans",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DepositPercentage",
                table: "RequestedPaymentPlans",
                type: "numeric(5,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ImpliedMonthlyPayment",
                table: "RequestedPaymentPlans",
                type: "numeric(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "MunicipalityAccountNumber",
                table: "RequestedPaymentPlans",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "RequestedPaymentPlans",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentPlan",
                table: "RequestedPaymentPlans",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReasonForPlan",
                table: "RequestedPaymentPlans",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SelectedAccount",
                table: "RequestedPaymentPlans",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "RequestedPaymentPlans",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RequestedPaymentPlans",
                table: "RequestedPaymentPlans",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestedPaymentPlans_Admin_AdminId",
                table: "RequestedPaymentPlans",
                column: "AdminId",
                principalTable: "Admin",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestedPaymentPlans_Admin_AdminId",
                table: "RequestedPaymentPlans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RequestedPaymentPlans",
                table: "RequestedPaymentPlans");

            migrationBuilder.DropColumn(
                name: "AmountDue",
                table: "RequestedPaymentPlans");

            migrationBuilder.DropColumn(
                name: "AmountPaidDown",
                table: "RequestedPaymentPlans");

            migrationBuilder.DropColumn(
                name: "ApplicationReference",
                table: "RequestedPaymentPlans");

            migrationBuilder.DropColumn(
                name: "ApprovalStatus",
                table: "RequestedPaymentPlans");

            migrationBuilder.DropColumn(
                name: "CellphoneNumber",
                table: "RequestedPaymentPlans");

            migrationBuilder.DropColumn(
                name: "DepositPercentage",
                table: "RequestedPaymentPlans");

            migrationBuilder.DropColumn(
                name: "ImpliedMonthlyPayment",
                table: "RequestedPaymentPlans");

            migrationBuilder.DropColumn(
                name: "MunicipalityAccountNumber",
                table: "RequestedPaymentPlans");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "RequestedPaymentPlans");

            migrationBuilder.DropColumn(
                name: "PaymentPlan",
                table: "RequestedPaymentPlans");

            migrationBuilder.DropColumn(
                name: "ReasonForPlan",
                table: "RequestedPaymentPlans");

            migrationBuilder.DropColumn(
                name: "SelectedAccount",
                table: "RequestedPaymentPlans");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "RequestedPaymentPlans");

            migrationBuilder.RenameTable(
                name: "RequestedPaymentPlans",
                newName: "RequestedPaymentPlans ");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "RequestedPaymentPlans ",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "AdminId",
                table: "RequestedPaymentPlans ",
                newName: "AdminID ");

            migrationBuilder.RenameIndex(
                name: "IX_RequestedPaymentPlans_AdminId",
                table: "RequestedPaymentPlans ",
                newName: "IX_RequestedPaymentPlans _AdminID ");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "RequestedPaymentPlans ",
                type: "character varying",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AdminID ",
                table: "RequestedPaymentPlans ",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Amount ",
                table: "RequestedPaymentPlans ",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Duration ",
                table: "RequestedPaymentPlans ",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SelectedPlan ",
                table: "RequestedPaymentPlans ",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status ",
                table: "RequestedPaymentPlans ",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TermsAndConditions ",
                table: "RequestedPaymentPlans ",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RequestedPaymentPlans ",
                table: "RequestedPaymentPlans ",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "RequestedPaymentPlans _AdminID _fkey",
                table: "RequestedPaymentPlans ",
                column: "AdminID ",
                principalTable: "Admin",
                principalColumn: "Id");
        }
    }
}
