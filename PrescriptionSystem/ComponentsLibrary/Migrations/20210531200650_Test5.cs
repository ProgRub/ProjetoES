using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComponentsLibrary.Migrations
{
    public partial class Test5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Item_AuthorId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Item_PatientId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Item_TherapistId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Item_TherapySession_PatientId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_AuthorId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_PatientId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_TherapistId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_TherapySession_PatientId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "AgeMaximum",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "AgeMinimum",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "BodyPart",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "HealthUserNumber",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Medicine_Description",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Medicine_Name",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Prescription_Description",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "TherapistId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "TherapySession_PatientId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Treatment_Description",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Treatment_Name",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Item");

            migrationBuilder.CreateTable(
                name: "HealthCareProfessional",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    HealthUserNumber = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthCareProfessional", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthCareProfessional_Item_Id",
                        column: x => x.Id,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicalCondition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalCondition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalCondition_Item_Id",
                        column: x => x.Id,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    HealthUserNumber = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patient_Item_Id",
                        column: x => x.Id,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PrescriptionItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrescriptionItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrescriptionItem_Item_Id",
                        column: x => x.Id,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Therapist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Therapist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Therapist_HealthCareProfessional_Id",
                        column: x => x.Id,
                        principalTable: "HealthCareProfessional",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prescription",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: true),
                    PatientId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prescription_HealthCareProfessional_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "HealthCareProfessional",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prescription_Item_Id",
                        column: x => x.Id,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prescription_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Exercise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    AgeMinimum = table.Column<int>(type: "int", nullable: false),
                    AgeMaximum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercise_PrescriptionItem_Id",
                        column: x => x.Id,
                        principalTable: "PrescriptionItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Medicine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medicine_PrescriptionItem_Id",
                        column: x => x.Id,
                        principalTable: "PrescriptionItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Treatment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    BodyPart = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    AgeMinimum = table.Column<int>(type: "int", nullable: false),
                    AgeMaximum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treatment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Treatment_PrescriptionItem_Id",
                        column: x => x.Id,
                        principalTable: "PrescriptionItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TherapySession",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    TherapistId = table.Column<int>(type: "int", nullable: true),
                    PatientId = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TherapySession", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TherapySession_Item_Id",
                        column: x => x.Id,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TherapySession_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TherapySession_Therapist_TherapistId",
                        column: x => x.TherapistId,
                        principalTable: "Therapist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PrescriptionHasPrescriptionItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    PrescriptionId = table.Column<int>(type: "int", nullable: true),
                    PrescriptionItemId = table.Column<int>(type: "int", nullable: true),
                    RecommendedTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrescriptionHasPrescriptionItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrescriptionHasPrescriptionItems_Item_Id",
                        column: x => x.Id,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrescriptionHasPrescriptionItems_Prescription_PrescriptionId",
                        column: x => x.PrescriptionId,
                        principalTable: "Prescription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrescriptionHasPrescriptionItems_PrescriptionItem_PrescriptionItemId",
                        column: x => x.PrescriptionItemId,
                        principalTable: "PrescriptionItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PrescriptionHasViewers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    PrescriptionId = table.Column<int>(type: "int", nullable: true),
                    HealthCareProfessionalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrescriptionHasViewers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrescriptionHasViewers_HealthCareProfessional_HealthCareProfessionalId",
                        column: x => x.HealthCareProfessionalId,
                        principalTable: "HealthCareProfessional",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrescriptionHasViewers_Item_Id",
                        column: x => x.Id,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PrescriptionHasViewers_Prescription_PrescriptionId",
                        column: x => x.PrescriptionId,
                        principalTable: "Prescription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseHasBodyParts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ExerciseId = table.Column<int>(type: "int", nullable: true),
                    BodyPart = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseHasBodyParts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExerciseHasBodyParts_Exercise_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExerciseHasBodyParts_Item_Id",
                        column: x => x.Id,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicineHasIncompatibleMedicalConditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    MedicalConditionId = table.Column<int>(type: "int", nullable: true),
                    MedicineId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicineHasIncompatibleMedicalConditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicineHasIncompatibleMedicalConditions_Item_Id",
                        column: x => x.Id,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicineHasIncompatibleMedicalConditions_MedicalCondition_MedicalConditionId",
                        column: x => x.MedicalConditionId,
                        principalTable: "MedicalCondition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicineHasIncompatibleMedicalConditions_Medicine_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TherapySessionHasTreatments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    TherapySessionId = table.Column<int>(type: "int", nullable: true),
                    TreatmentId = table.Column<int>(type: "int", nullable: true),
                    CompletedTreatment = table.Column<bool>(type: "bit", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TherapySessionHasTreatments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TherapySessionHasTreatments_Item_Id",
                        column: x => x.Id,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TherapySessionHasTreatments_TherapySession_TherapySessionId",
                        column: x => x.TherapySessionId,
                        principalTable: "TherapySession",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TherapySessionHasTreatments_Treatment_TreatmentId",
                        column: x => x.TreatmentId,
                        principalTable: "Treatment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseHasBodyParts_ExerciseId",
                table: "ExerciseHasBodyParts",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicineHasIncompatibleMedicalConditions_MedicalConditionId",
                table: "MedicineHasIncompatibleMedicalConditions",
                column: "MedicalConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicineHasIncompatibleMedicalConditions_MedicineId",
                table: "MedicineHasIncompatibleMedicalConditions",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_AuthorId",
                table: "Prescription",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_PatientId",
                table: "Prescription",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionHasPrescriptionItems_PrescriptionId",
                table: "PrescriptionHasPrescriptionItems",
                column: "PrescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionHasPrescriptionItems_PrescriptionItemId",
                table: "PrescriptionHasPrescriptionItems",
                column: "PrescriptionItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionHasViewers_HealthCareProfessionalId",
                table: "PrescriptionHasViewers",
                column: "HealthCareProfessionalId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionHasViewers_PrescriptionId",
                table: "PrescriptionHasViewers",
                column: "PrescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_TherapySession_PatientId",
                table: "TherapySession",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_TherapySession_TherapistId",
                table: "TherapySession",
                column: "TherapistId");

            migrationBuilder.CreateIndex(
                name: "IX_TherapySessionHasTreatments_TherapySessionId",
                table: "TherapySessionHasTreatments",
                column: "TherapySessionId");

            migrationBuilder.CreateIndex(
                name: "IX_TherapySessionHasTreatments_TreatmentId",
                table: "TherapySessionHasTreatments",
                column: "TreatmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseHasBodyParts");

            migrationBuilder.DropTable(
                name: "MedicineHasIncompatibleMedicalConditions");

            migrationBuilder.DropTable(
                name: "PrescriptionHasPrescriptionItems");

            migrationBuilder.DropTable(
                name: "PrescriptionHasViewers");

            migrationBuilder.DropTable(
                name: "TherapySessionHasTreatments");

            migrationBuilder.DropTable(
                name: "Exercise");

            migrationBuilder.DropTable(
                name: "MedicalCondition");

            migrationBuilder.DropTable(
                name: "Medicine");

            migrationBuilder.DropTable(
                name: "Prescription");

            migrationBuilder.DropTable(
                name: "TherapySession");

            migrationBuilder.DropTable(
                name: "Treatment");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Therapist");

            migrationBuilder.DropTable(
                name: "PrescriptionItem");

            migrationBuilder.DropTable(
                name: "HealthCareProfessional");

            migrationBuilder.AddColumn<int>(
                name: "AgeMaximum",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AgeMinimum",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BodyPart",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Item",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Item",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Item",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Duration",
                table: "Item",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Item",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HealthUserNumber",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Medicine_Description",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Medicine_Name",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhoneNumber",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Prescription_Description",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Item",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Item",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TherapistId",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TherapySession_PatientId",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Treatment_Description",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Treatment_Name",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Item_AuthorId",
                table: "Item",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_PatientId",
                table: "Item",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_TherapistId",
                table: "Item",
                column: "TherapistId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_TherapySession_PatientId",
                table: "Item",
                column: "TherapySession_PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Item_AuthorId",
                table: "Item",
                column: "AuthorId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Item_PatientId",
                table: "Item",
                column: "PatientId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Item_TherapistId",
                table: "Item",
                column: "TherapistId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Item_TherapySession_PatientId",
                table: "Item",
                column: "TherapySession_PatientId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
