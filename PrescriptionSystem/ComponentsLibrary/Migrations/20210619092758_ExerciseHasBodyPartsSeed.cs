using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComponentsLibrary.Migrations
{
    public partial class ExerciseHasBodyPartsSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseHasBodyParts_Exercise_ExerciseId",
                table: "ExerciseHasBodyParts");

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
                name: "ExerciseId",
                table: "ExerciseHasBodyParts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Item",
                column: "Id",
                values: new object[]
                {
                    100,
                    101,
                    102,
                    103,
                    104,
                    105,
                    106,
                    107,
                    108
                });

            migrationBuilder.InsertData(
                table: "ExerciseHasBodyParts",
                columns: new[] { "Id", "BodyPart", "ExerciseId" },
                values: new object[,]
                {
                    { 100, 3, 8 },
                    { 101, 2, 8 },
                    { 102, 4, 8 },
                    { 103, 5, 8 },
                    { 104, 3, 9 },
                    { 105, 2, 9 },
                    { 106, 1, 9 },
                    { 107, 4, 10 },
                    { 108, 5, 10 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseHasBodyParts_Exercise_ExerciseId",
                table: "ExerciseHasBodyParts",
                column: "ExerciseId",
                principalTable: "Exercise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseHasBodyParts_Exercise_ExerciseId",
                table: "ExerciseHasBodyParts");

            migrationBuilder.DeleteData(
                table: "ExerciseHasBodyParts",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ExerciseHasBodyParts",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ExerciseHasBodyParts",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ExerciseHasBodyParts",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ExerciseHasBodyParts",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ExerciseHasBodyParts",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ExerciseHasBodyParts",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ExerciseHasBodyParts",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ExerciseHasBodyParts",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.AlterColumn<int>(
                name: "ExerciseId",
                table: "ExerciseHasBodyParts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                name: "FK_ExerciseHasBodyParts_Exercise_ExerciseId",
                table: "ExerciseHasBodyParts",
                column: "ExerciseId",
                principalTable: "Exercise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
