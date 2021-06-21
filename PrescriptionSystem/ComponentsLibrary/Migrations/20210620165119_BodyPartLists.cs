using Microsoft.EntityFrameworkCore.Migrations;

namespace ComponentsLibrary.Migrations
{
    public partial class BodyPartLists : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseHasBodyParts");

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

            migrationBuilder.AddColumn<string>(
                name: "MissingBodyParts",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BodyParts",
                table: "Exercise",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MissingBodyParts",
                table: "User");

            migrationBuilder.DropColumn(
                name: "BodyParts",
                table: "Exercise");

            migrationBuilder.CreateTable(
                name: "ExerciseHasBodyParts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    BodyPart = table.Column<int>(type: "int", nullable: false),
                    ExerciseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseHasBodyParts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExerciseHasBodyParts_Exercise_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseHasBodyParts_Item_Id",
                        column: x => x.Id,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseHasBodyParts_ExerciseId",
                table: "ExerciseHasBodyParts",
                column: "ExerciseId");
        }
    }
}
