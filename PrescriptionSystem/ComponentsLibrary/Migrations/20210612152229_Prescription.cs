using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComponentsLibrary.Migrations
{
    public partial class Prescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_HealthCareProfessional_AuthorId",
                table: "Prescription");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Patient_PatientId",
                table: "Prescription");

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "Prescription",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Prescription",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Item",
                column: "Id",
                value: 21);

            migrationBuilder.InsertData(
                table: "TherapySession",
                columns: new[] { "Id", "DateTime", "EstimatedDuration", "Note", "PatientId", "TherapistId" },
                values: new object[] { 21, new DateTime(2021, 6, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0), "", 16, 18 });

            migrationBuilder.InsertData(
                table: "TherapySessionHasTreatments",
                columns: new[] { "TherapySessionId", "TreatmentId", "CompletedTreatment", "Note" },
                values: new object[] { 21, 7, false, "" });

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_HealthCareProfessional_AuthorId",
                table: "Prescription",
                column: "AuthorId",
                principalTable: "HealthCareProfessional",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Patient_PatientId",
                table: "Prescription",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_HealthCareProfessional_AuthorId",
                table: "Prescription");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Patient_PatientId",
                table: "Prescription");

            migrationBuilder.DeleteData(
                table: "TherapySessionHasTreatments",
                keyColumns: new[] { "TherapySessionId", "TreatmentId" },
                keyValues: new object[] { 21, 7 });

            migrationBuilder.DeleteData(
                table: "TherapySession",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "Prescription",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Prescription",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_HealthCareProfessional_AuthorId",
                table: "Prescription",
                column: "AuthorId",
                principalTable: "HealthCareProfessional",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Patient_PatientId",
                table: "Prescription",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
