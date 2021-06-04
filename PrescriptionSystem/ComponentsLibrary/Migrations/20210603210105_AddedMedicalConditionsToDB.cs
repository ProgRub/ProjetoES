using Microsoft.EntityFrameworkCore.Migrations;

namespace ComponentsLibrary.Migrations
{
    public partial class AddedMedicalConditionsToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Item",
                column: "Id",
                values: new object[]
                {
                    11,
                    12,
                    13,
                    14,
                    15
                });

            migrationBuilder.InsertData(
                table: "MedicalCondition",
                columns: new[] { "Id", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 11, "", "Penicillin", 0 },
                    { 12, "", "Aspirin", 0 },
                    { 13, "", "Ibuprofen", 0 },
                    { 14, "", "Hypertension", 1 },
                    { 15, "This type of arthritis affects specifically the knees", "Knee Osteoarthritis", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MedicalCondition",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MedicalCondition",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MedicalCondition",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MedicalCondition",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MedicalCondition",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
