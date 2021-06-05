using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComponentsLibrary.Migrations
{
    public partial class CorrectedManyToManyTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicineHasIncompatibleMedicalConditions_Item_Id",
                table: "MedicineHasIncompatibleMedicalConditions");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicineHasIncompatibleMedicalConditions_MedicalCondition_MedicalConditionId",
                table: "MedicineHasIncompatibleMedicalConditions");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicineHasIncompatibleMedicalConditions_Medicine_MedicineId",
                table: "MedicineHasIncompatibleMedicalConditions");

            migrationBuilder.DropForeignKey(
                name: "FK_PrescriptionHasPrescriptionItems_Item_Id",
                table: "PrescriptionHasPrescriptionItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PrescriptionHasPrescriptionItems_Prescription_PrescriptionId",
                table: "PrescriptionHasPrescriptionItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PrescriptionHasPrescriptionItems_PrescriptionItem_PrescriptionItemId",
                table: "PrescriptionHasPrescriptionItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PrescriptionHasViewers_HealthCareProfessional_HealthCareProfessionalId",
                table: "PrescriptionHasViewers");

            migrationBuilder.DropForeignKey(
                name: "FK_PrescriptionHasViewers_Item_Id",
                table: "PrescriptionHasViewers");

            migrationBuilder.DropForeignKey(
                name: "FK_PrescriptionHasViewers_Prescription_PrescriptionId",
                table: "PrescriptionHasViewers");

            migrationBuilder.DropForeignKey(
                name: "FK_TherapySessionHasTreatments_Item_Id",
                table: "TherapySessionHasTreatments");

            migrationBuilder.DropForeignKey(
                name: "FK_TherapySessionHasTreatments_TherapySession_TherapySessionId",
                table: "TherapySessionHasTreatments");

            migrationBuilder.DropForeignKey(
                name: "FK_TherapySessionHasTreatments_Treatment_TreatmentId",
                table: "TherapySessionHasTreatments");

            migrationBuilder.DropForeignKey(
                name: "FK_UserHasMedicalCondition_Item_Id",
                table: "UserHasMedicalCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_UserHasMedicalCondition_MedicalCondition_MedicalConditionId",
                table: "UserHasMedicalCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_UserHasMedicalCondition_User_UserId",
                table: "UserHasMedicalCondition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserHasMedicalCondition",
                table: "UserHasMedicalCondition");

            migrationBuilder.DropIndex(
                name: "IX_UserHasMedicalCondition_MedicalConditionId",
                table: "UserHasMedicalCondition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TherapySessionHasTreatments",
                table: "TherapySessionHasTreatments");

            migrationBuilder.DropIndex(
                name: "IX_TherapySessionHasTreatments_TherapySessionId",
                table: "TherapySessionHasTreatments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrescriptionHasViewers",
                table: "PrescriptionHasViewers");

            migrationBuilder.DropIndex(
                name: "IX_PrescriptionHasViewers_HealthCareProfessionalId",
                table: "PrescriptionHasViewers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrescriptionHasPrescriptionItems",
                table: "PrescriptionHasPrescriptionItems");

            migrationBuilder.DropIndex(
                name: "IX_PrescriptionHasPrescriptionItems_PrescriptionId",
                table: "PrescriptionHasPrescriptionItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicineHasIncompatibleMedicalConditions",
                table: "MedicineHasIncompatibleMedicalConditions");

            migrationBuilder.DropIndex(
                name: "IX_MedicineHasIncompatibleMedicalConditions_MedicineId",
                table: "MedicineHasIncompatibleMedicalConditions");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserHasMedicalCondition");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TherapySessionHasTreatments");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PrescriptionHasViewers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PrescriptionHasPrescriptionItems");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MedicineHasIncompatibleMedicalConditions");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserHasMedicalCondition",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MedicalConditionId",
                table: "UserHasMedicalCondition",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "TimeStamp",
                table: "UserHasMedicalCondition",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Zombie",
                table: "UserHasMedicalCondition",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "TreatmentId",
                table: "TherapySessionHasTreatments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TherapySessionId",
                table: "TherapySessionHasTreatments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "TimeStamp",
                table: "TherapySessionHasTreatments",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Zombie",
                table: "TherapySessionHasTreatments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "PrescriptionId",
                table: "PrescriptionHasViewers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HealthCareProfessionalId",
                table: "PrescriptionHasViewers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "TimeStamp",
                table: "PrescriptionHasViewers",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Zombie",
                table: "PrescriptionHasViewers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "PrescriptionItemId",
                table: "PrescriptionHasPrescriptionItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PrescriptionId",
                table: "PrescriptionHasPrescriptionItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "TimeStamp",
                table: "PrescriptionHasPrescriptionItems",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Zombie",
                table: "PrescriptionHasPrescriptionItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "MedicineId",
                table: "MedicineHasIncompatibleMedicalConditions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MedicalConditionId",
                table: "MedicineHasIncompatibleMedicalConditions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "TimeStamp",
                table: "MedicineHasIncompatibleMedicalConditions",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Zombie",
                table: "MedicineHasIncompatibleMedicalConditions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserHasMedicalCondition",
                table: "UserHasMedicalCondition",
                columns: new[] { "MedicalConditionId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_TherapySessionHasTreatments",
                table: "TherapySessionHasTreatments",
                columns: new[] { "TherapySessionId", "TreatmentId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrescriptionHasViewers",
                table: "PrescriptionHasViewers",
                columns: new[] { "HealthCareProfessionalId", "PrescriptionId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrescriptionHasPrescriptionItems",
                table: "PrescriptionHasPrescriptionItems",
                columns: new[] { "PrescriptionId", "PrescriptionItemId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicineHasIncompatibleMedicalConditions",
                table: "MedicineHasIncompatibleMedicalConditions",
                columns: new[] { "MedicineId", "MedicalConditionId" });

            migrationBuilder.AddForeignKey(
                name: "FK_MedicineHasIncompatibleMedicalConditions_MedicalCondition_MedicalConditionId",
                table: "MedicineHasIncompatibleMedicalConditions",
                column: "MedicalConditionId",
                principalTable: "MedicalCondition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicineHasIncompatibleMedicalConditions_Medicine_MedicineId",
                table: "MedicineHasIncompatibleMedicalConditions",
                column: "MedicineId",
                principalTable: "Medicine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrescriptionHasPrescriptionItems_Prescription_PrescriptionId",
                table: "PrescriptionHasPrescriptionItems",
                column: "PrescriptionId",
                principalTable: "Prescription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrescriptionHasPrescriptionItems_PrescriptionItem_PrescriptionItemId",
                table: "PrescriptionHasPrescriptionItems",
                column: "PrescriptionItemId",
                principalTable: "PrescriptionItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrescriptionHasViewers_HealthCareProfessional_HealthCareProfessionalId",
                table: "PrescriptionHasViewers",
                column: "HealthCareProfessionalId",
                principalTable: "HealthCareProfessional",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrescriptionHasViewers_Prescription_PrescriptionId",
                table: "PrescriptionHasViewers",
                column: "PrescriptionId",
                principalTable: "Prescription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TherapySessionHasTreatments_TherapySession_TherapySessionId",
                table: "TherapySessionHasTreatments",
                column: "TherapySessionId",
                principalTable: "TherapySession",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TherapySessionHasTreatments_Treatment_TreatmentId",
                table: "TherapySessionHasTreatments",
                column: "TreatmentId",
                principalTable: "Treatment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserHasMedicalCondition_MedicalCondition_MedicalConditionId",
                table: "UserHasMedicalCondition",
                column: "MedicalConditionId",
                principalTable: "MedicalCondition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserHasMedicalCondition_User_UserId",
                table: "UserHasMedicalCondition",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicineHasIncompatibleMedicalConditions_MedicalCondition_MedicalConditionId",
                table: "MedicineHasIncompatibleMedicalConditions");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicineHasIncompatibleMedicalConditions_Medicine_MedicineId",
                table: "MedicineHasIncompatibleMedicalConditions");

            migrationBuilder.DropForeignKey(
                name: "FK_PrescriptionHasPrescriptionItems_Prescription_PrescriptionId",
                table: "PrescriptionHasPrescriptionItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PrescriptionHasPrescriptionItems_PrescriptionItem_PrescriptionItemId",
                table: "PrescriptionHasPrescriptionItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PrescriptionHasViewers_HealthCareProfessional_HealthCareProfessionalId",
                table: "PrescriptionHasViewers");

            migrationBuilder.DropForeignKey(
                name: "FK_PrescriptionHasViewers_Prescription_PrescriptionId",
                table: "PrescriptionHasViewers");

            migrationBuilder.DropForeignKey(
                name: "FK_TherapySessionHasTreatments_TherapySession_TherapySessionId",
                table: "TherapySessionHasTreatments");

            migrationBuilder.DropForeignKey(
                name: "FK_TherapySessionHasTreatments_Treatment_TreatmentId",
                table: "TherapySessionHasTreatments");

            migrationBuilder.DropForeignKey(
                name: "FK_UserHasMedicalCondition_MedicalCondition_MedicalConditionId",
                table: "UserHasMedicalCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_UserHasMedicalCondition_User_UserId",
                table: "UserHasMedicalCondition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserHasMedicalCondition",
                table: "UserHasMedicalCondition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TherapySessionHasTreatments",
                table: "TherapySessionHasTreatments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrescriptionHasViewers",
                table: "PrescriptionHasViewers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrescriptionHasPrescriptionItems",
                table: "PrescriptionHasPrescriptionItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicineHasIncompatibleMedicalConditions",
                table: "MedicineHasIncompatibleMedicalConditions");

            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "UserHasMedicalCondition");

            migrationBuilder.DropColumn(
                name: "Zombie",
                table: "UserHasMedicalCondition");

            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "TherapySessionHasTreatments");

            migrationBuilder.DropColumn(
                name: "Zombie",
                table: "TherapySessionHasTreatments");

            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "PrescriptionHasViewers");

            migrationBuilder.DropColumn(
                name: "Zombie",
                table: "PrescriptionHasViewers");

            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "PrescriptionHasPrescriptionItems");

            migrationBuilder.DropColumn(
                name: "Zombie",
                table: "PrescriptionHasPrescriptionItems");

            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "MedicineHasIncompatibleMedicalConditions");

            migrationBuilder.DropColumn(
                name: "Zombie",
                table: "MedicineHasIncompatibleMedicalConditions");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserHasMedicalCondition",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MedicalConditionId",
                table: "UserHasMedicalCondition",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "UserHasMedicalCondition",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "TreatmentId",
                table: "TherapySessionHasTreatments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TherapySessionId",
                table: "TherapySessionHasTreatments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TherapySessionHasTreatments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "PrescriptionId",
                table: "PrescriptionHasViewers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "HealthCareProfessionalId",
                table: "PrescriptionHasViewers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PrescriptionHasViewers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "PrescriptionItemId",
                table: "PrescriptionHasPrescriptionItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PrescriptionId",
                table: "PrescriptionHasPrescriptionItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PrescriptionHasPrescriptionItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "MedicalConditionId",
                table: "MedicineHasIncompatibleMedicalConditions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MedicineId",
                table: "MedicineHasIncompatibleMedicalConditions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "MedicineHasIncompatibleMedicalConditions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserHasMedicalCondition",
                table: "UserHasMedicalCondition",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TherapySessionHasTreatments",
                table: "TherapySessionHasTreatments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrescriptionHasViewers",
                table: "PrescriptionHasViewers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrescriptionHasPrescriptionItems",
                table: "PrescriptionHasPrescriptionItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicineHasIncompatibleMedicalConditions",
                table: "MedicineHasIncompatibleMedicalConditions",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserHasMedicalCondition_MedicalConditionId",
                table: "UserHasMedicalCondition",
                column: "MedicalConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_TherapySessionHasTreatments_TherapySessionId",
                table: "TherapySessionHasTreatments",
                column: "TherapySessionId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionHasViewers_HealthCareProfessionalId",
                table: "PrescriptionHasViewers",
                column: "HealthCareProfessionalId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionHasPrescriptionItems_PrescriptionId",
                table: "PrescriptionHasPrescriptionItems",
                column: "PrescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicineHasIncompatibleMedicalConditions_MedicineId",
                table: "MedicineHasIncompatibleMedicalConditions",
                column: "MedicineId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicineHasIncompatibleMedicalConditions_Item_Id",
                table: "MedicineHasIncompatibleMedicalConditions",
                column: "Id",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicineHasIncompatibleMedicalConditions_MedicalCondition_MedicalConditionId",
                table: "MedicineHasIncompatibleMedicalConditions",
                column: "MedicalConditionId",
                principalTable: "MedicalCondition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicineHasIncompatibleMedicalConditions_Medicine_MedicineId",
                table: "MedicineHasIncompatibleMedicalConditions",
                column: "MedicineId",
                principalTable: "Medicine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrescriptionHasPrescriptionItems_Item_Id",
                table: "PrescriptionHasPrescriptionItems",
                column: "Id",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrescriptionHasPrescriptionItems_Prescription_PrescriptionId",
                table: "PrescriptionHasPrescriptionItems",
                column: "PrescriptionId",
                principalTable: "Prescription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrescriptionHasPrescriptionItems_PrescriptionItem_PrescriptionItemId",
                table: "PrescriptionHasPrescriptionItems",
                column: "PrescriptionItemId",
                principalTable: "PrescriptionItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrescriptionHasViewers_HealthCareProfessional_HealthCareProfessionalId",
                table: "PrescriptionHasViewers",
                column: "HealthCareProfessionalId",
                principalTable: "HealthCareProfessional",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrescriptionHasViewers_Item_Id",
                table: "PrescriptionHasViewers",
                column: "Id",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrescriptionHasViewers_Prescription_PrescriptionId",
                table: "PrescriptionHasViewers",
                column: "PrescriptionId",
                principalTable: "Prescription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TherapySessionHasTreatments_Item_Id",
                table: "TherapySessionHasTreatments",
                column: "Id",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TherapySessionHasTreatments_TherapySession_TherapySessionId",
                table: "TherapySessionHasTreatments",
                column: "TherapySessionId",
                principalTable: "TherapySession",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TherapySessionHasTreatments_Treatment_TreatmentId",
                table: "TherapySessionHasTreatments",
                column: "TreatmentId",
                principalTable: "Treatment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserHasMedicalCondition_Item_Id",
                table: "UserHasMedicalCondition",
                column: "Id",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserHasMedicalCondition_MedicalCondition_MedicalConditionId",
                table: "UserHasMedicalCondition",
                column: "MedicalConditionId",
                principalTable: "MedicalCondition",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserHasMedicalCondition_User_UserId",
                table: "UserHasMedicalCondition",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
