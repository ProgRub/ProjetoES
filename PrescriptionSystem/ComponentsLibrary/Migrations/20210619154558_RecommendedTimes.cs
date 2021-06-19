using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComponentsLibrary.Migrations
{
    public partial class RecommendedTimes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecommendedTime",
                table: "PrescriptionHasPrescriptionItems");

            migrationBuilder.AddColumn<string>(
                name: "RecommendedTimes",
                table: "PrescriptionHasPrescriptionItems",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecommendedTimes",
                table: "PrescriptionHasPrescriptionItems");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "RecommendedTime",
                table: "PrescriptionHasPrescriptionItems",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }
    }
}
