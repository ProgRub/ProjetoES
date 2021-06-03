using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComponentsLibrary.Migrations
{
    public partial class BasicDataPrescriptionItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Item",
                column: "Id",
                values: new object[]
                {
                    8,
                    9,
                    10,
                    1,
                    2,
                    3,
                    4,
                    5,
                    6,
                    7
                });

            migrationBuilder.InsertData(
                table: "PrescriptionItem",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 8, "From standing up, drop into a high plank and then jump your feet to your hands, stand up and jump with your arms up. Repeat.", "Burpees" },
                    { 9, "", "Pushups" },
                    { 10, "Make sure your knees don't go in front of your feet", "Squats" },
                    { 1, "", "Penicillin" },
                    { 2, "", "Streptomycin" },
                    { 3, "", "Pyrazolones" },
                    { 4, "Treatment given to people with torn triceps on their right arm", "Torn Triceps" },
                    { 5, "Treatment given to people with torn triceps on their left arm", "Torn Triceps" },
                    { 6, "An ice pack is needed for this treatment", "Hyper-extended Knee" },
                    { 7, "An ice pack is needed for this treatment", "Hyper-extended Knee" }
                });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AgeMaximum", "AgeMinimum", "Duration" },
                values: new object[,]
                {
                    { 8, 50, 15, new TimeSpan(0, 0, 10, 0, 0) },
                    { 9, 78, 8, new TimeSpan(0, 0, 20, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "AgeMinimum", "Duration" },
                values: new object[] { 10, 5, new TimeSpan(0, 0, 15, 0, 0) });

            migrationBuilder.InsertData(
                table: "Medicine",
                columns: new[] { "Id", "Price" },
                values: new object[,]
                {
                    { 1, 2.3199999999999998 },
                    { 2, 4.5700000000000003 },
                    { 3, 12.4 }
                });

            migrationBuilder.InsertData(
                table: "Treatment",
                columns: new[] { "Id", "BodyPart", "Duration" },
                values: new object[,]
                {
                    { 4, 3, new TimeSpan(0, 0, 30, 0, 0) },
                    { 5, 2, new TimeSpan(0, 0, 30, 0, 0) },
                    { 6, 4, new TimeSpan(0, 1, 0, 0, 0) },
                    { 7, 5, new TimeSpan(0, 1, 0, 0, 0) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medicine",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Treatment",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Treatment",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Treatment",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Treatment",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PrescriptionItem",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PrescriptionItem",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PrescriptionItem",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PrescriptionItem",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PrescriptionItem",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PrescriptionItem",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PrescriptionItem",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PrescriptionItem",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PrescriptionItem",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PrescriptionItem",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
