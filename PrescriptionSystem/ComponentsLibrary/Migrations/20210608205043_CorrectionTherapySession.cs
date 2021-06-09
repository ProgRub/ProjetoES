using Microsoft.EntityFrameworkCore.Migrations;

namespace ComponentsLibrary.Migrations
{
    public partial class CorrectionTherapySession : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TherapySession_Patient_PatientId",
                table: "TherapySession");

            migrationBuilder.DropForeignKey(
                name: "FK_TherapySession_Therapist_TherapistId",
                table: "TherapySession");

            migrationBuilder.AlterColumn<int>(
                name: "TherapistId",
                table: "TherapySession",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "TherapySession",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TherapySession_Patient_PatientId",
                table: "TherapySession",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TherapySession_Therapist_TherapistId",
                table: "TherapySession",
                column: "TherapistId",
                principalTable: "Therapist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TherapySession_Patient_PatientId",
                table: "TherapySession");

            migrationBuilder.DropForeignKey(
                name: "FK_TherapySession_Therapist_TherapistId",
                table: "TherapySession");

            migrationBuilder.AlterColumn<int>(
                name: "TherapistId",
                table: "TherapySession",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "TherapySession",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TherapySession_Patient_PatientId",
                table: "TherapySession",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TherapySession_Therapist_TherapistId",
                table: "TherapySession",
                column: "TherapistId",
                principalTable: "Therapist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
