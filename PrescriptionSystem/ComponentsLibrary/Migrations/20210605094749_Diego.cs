using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComponentsLibrary.Migrations
{
    public partial class Diego : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Item",
                column: "Id",
                values: new object[]
                {
                    16,
                    17,
                    18,
                    19
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "DateOfBirth", "Email", "FullName", "HealthUserNumber", "Password", "PhoneNumber" },
                values: new object[,]
                {
                    { 16, new DateTime(1985, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "luisbrito@gmail.com", "Luís Brito", 243719236, "luis123", 924837193 },
                    { 17, new DateTime(1994, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "marybreu@hotmail.com", "Mariana Abreu", 295831023, "M_A_R_Y", 968391023 },
                    { 18, new DateTime(1975, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "carlanunes1975@hotmail.com", "Carla Nunes", 291039113, "carlaaa", 917009283 },
                    { 19, new DateTime(1958, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "nobregarui@hotmail.com", "Rui Nóbrega", 200192356, "ruiruirui", 969070184 }
                });

            migrationBuilder.InsertData(
                table: "HealthCareProfessional",
                column: "Id",
                values: new object[]
                {
                    18,
                    19
                });

            migrationBuilder.InsertData(
                table: "Patient",
                column: "Id",
                values: new object[]
                {
                    16,
                    17
                });

            migrationBuilder.InsertData(
                table: "Therapist",
                column: "Id",
                value: 18);

            migrationBuilder.InsertData(
                table: "Therapist",
                column: "Id",
                value: 19);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Therapist",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Therapist",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "HealthCareProfessional",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "HealthCareProfessional",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 19);
        }
    }
}
