using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComponentsLibrary.Migrations
{
    public partial class TherapySessionTableCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "TherapySession",
                newName: "DateTime");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "EstimatedDuration",
                table: "TherapySession",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstimatedDuration",
                table: "TherapySession");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "TherapySession",
                newName: "Date");
        }
    }
}
