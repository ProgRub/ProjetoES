using Microsoft.EntityFrameworkCore.Migrations;

namespace ComponentsLibrary.Migrations
{
    public partial class RemovedBodyPartTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserHasMissingBodyPart");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserHasMissingBodyPart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    BodyPart = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
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
                name: "IX_UserHasMissingBodyPart_UserId",
                table: "UserHasMissingBodyPart",
                column: "UserId");
        }
    }
}
