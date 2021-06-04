using Microsoft.EntityFrameworkCore.Migrations;

namespace ComponentsLibrary.Migrations
{
    public partial class Corrections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "CompletedTreatment",
                table: "TherapySessionHasTreatments",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "CompletedTreatment",
                table: "TherapySessionHasTreatments",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);
        }
    }
}
