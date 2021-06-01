using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComponentsLibrary.Migrations
{
    public partial class Test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgeMaximum",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AgeMinimum",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BodyPart",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Item",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Item",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Item",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Duration",
                table: "Item",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Item",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HealthUserNumber",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Medicine_Description",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Medicine_Name",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhoneNumber",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Prescription_Description",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Item",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Item",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TherapistId",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TherapySession_PatientId",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Treatment_Description",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Treatment_Name",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Item_AuthorId",
                table: "Item",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_PatientId",
                table: "Item",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_TherapistId",
                table: "Item",
                column: "TherapistId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_TherapySession_PatientId",
                table: "Item",
                column: "TherapySession_PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Item_AuthorId",
                table: "Item",
                column: "AuthorId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Item_PatientId",
                table: "Item",
                column: "PatientId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Item_TherapistId",
                table: "Item",
                column: "TherapistId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Item_TherapySession_PatientId",
                table: "Item",
                column: "TherapySession_PatientId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Item_AuthorId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Item_PatientId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Item_TherapistId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Item_TherapySession_PatientId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_AuthorId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_PatientId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_TherapistId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_TherapySession_PatientId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "AgeMaximum",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "AgeMinimum",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "BodyPart",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "HealthUserNumber",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Medicine_Description",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Medicine_Name",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Prescription_Description",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "TherapistId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "TherapySession_PatientId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Treatment_Description",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Treatment_Name",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Item");
        }
    }
}
