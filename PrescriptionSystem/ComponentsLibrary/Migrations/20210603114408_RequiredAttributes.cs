using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComponentsLibrary.Migrations
{
    public partial class RequiredAttributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HealthCareProfessional_Item_Id",
                table: "HealthCareProfessional");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Item_Id",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "HealthUserNumber",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "HealthCareProfessional");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "HealthCareProfessional");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "HealthCareProfessional");

            migrationBuilder.DropColumn(
                name: "HealthUserNumber",
                table: "HealthCareProfessional");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "HealthCareProfessional");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "HealthCareProfessional");

            migrationBuilder.AlterColumn<int>(
                name: "AgeMinimum",
                table: "Treatment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AgeMaximum",
                table: "Treatment",
                type: "int",
                nullable: false,
                defaultValue: 150,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PrescriptionItem",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AgeMinimum",
                table: "Exercise",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AgeMaximum",
                table: "Exercise",
                type: "int",
                nullable: false,
                defaultValue: 150,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    HealthUserNumber = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Item_Id",
                        column: x => x.Id,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_HealthCareProfessional_User_Id",
                table: "HealthCareProfessional",
                column: "Id",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_User_Id",
                table: "Patient",
                column: "Id",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HealthCareProfessional_User_Id",
                table: "HealthCareProfessional");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_User_Id",
                table: "Patient");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.AlterColumn<int>(
                name: "AgeMinimum",
                table: "Treatment",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "AgeMaximum",
                table: "Treatment",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PrescriptionItem",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Patient",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HealthUserNumber",
                table: "Patient",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhoneNumber",
                table: "Patient",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "HealthCareProfessional",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "HealthCareProfessional",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "HealthCareProfessional",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HealthUserNumber",
                table: "HealthCareProfessional",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "HealthCareProfessional",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhoneNumber",
                table: "HealthCareProfessional",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "AgeMinimum",
                table: "Exercise",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "AgeMaximum",
                table: "Exercise",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 150);

            migrationBuilder.AddForeignKey(
                name: "FK_HealthCareProfessional_Item_Id",
                table: "HealthCareProfessional",
                column: "Id",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Item_Id",
                table: "Patient",
                column: "Id",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
