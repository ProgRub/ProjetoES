using Microsoft.EntityFrameworkCore.Migrations;

namespace ComponentsLibrary.Migrations
{
    public partial class CorrectMissingTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserHasMedicalCondition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    MedicalConditionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserHasMedicalCondition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserHasMedicalCondition_Item_Id",
                        column: x => x.Id,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserHasMedicalCondition_MedicalCondition_MedicalConditionId",
                        column: x => x.MedicalConditionId,
                        principalTable: "MedicalCondition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserHasMedicalCondition_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserHasMissingBodyPart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    BodyPart = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserHasMissingBodyPart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserHasMissingBodyPart_Item_Id",
                        column: x => x.Id,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserHasMissingBodyPart_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserHasMedicalCondition_MedicalConditionId",
                table: "UserHasMedicalCondition",
                column: "MedicalConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserHasMedicalCondition_UserId",
                table: "UserHasMedicalCondition",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserHasMissingBodyPart_UserId",
                table: "UserHasMissingBodyPart",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserHasMedicalCondition");

            migrationBuilder.DropTable(
                name: "UserHasMissingBodyPart");
        }
    }
}
