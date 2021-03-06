// <auto-generated />
using System;
using ComponentsLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ComponentsLibrary.Migrations
{
    [DbContext(typeof(PrescriptionSystemDbContext))]
    [Migration("20210603114408_RequiredAttributes")]
    partial class RequiredAttributes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ComponentsLibrary.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<bool>("Zombie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.MedicalCondition", b =>
                {
                    b.HasBaseType("ComponentsLibrary.Entities.Item");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.ToTable("MedicalCondition");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.Prescription", b =>
                {
                    b.HasBaseType("ComponentsLibrary.Entities.Item");

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Prescription");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.PrescriptionHasPrescriptionItems", b =>
                {
                    b.HasBaseType("ComponentsLibrary.Entities.Item");

                    b.Property<int?>("PrescriptionId")
                        .HasColumnType("int");

                    b.Property<int?>("PrescriptionItemId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("RecommendedTime")
                        .HasColumnType("time");

                    b.HasIndex("PrescriptionId");

                    b.HasIndex("PrescriptionItemId");

                    b.ToTable("PrescriptionHasPrescriptionItems");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.PrescriptionHasViewers", b =>
                {
                    b.HasBaseType("ComponentsLibrary.Entities.Item");

                    b.Property<int?>("HealthCareProfessionalId")
                        .HasColumnType("int");

                    b.Property<int?>("PrescriptionId")
                        .HasColumnType("int");

                    b.HasIndex("HealthCareProfessionalId");

                    b.HasIndex("PrescriptionId");

                    b.ToTable("PrescriptionHasViewers");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.PrescriptionItems.ExerciseHasBodyParts", b =>
                {
                    b.HasBaseType("ComponentsLibrary.Entities.Item");

                    b.Property<int>("BodyPart")
                        .HasColumnType("int");

                    b.Property<int?>("ExerciseId")
                        .HasColumnType("int");

                    b.HasIndex("ExerciseId");

                    b.ToTable("ExerciseHasBodyParts");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.PrescriptionItems.MedicineHasIncompatibleMedicalConditions", b =>
                {
                    b.HasBaseType("ComponentsLibrary.Entities.Item");

                    b.Property<int?>("MedicalConditionId")
                        .HasColumnType("int");

                    b.Property<int?>("MedicineId")
                        .HasColumnType("int");

                    b.HasIndex("MedicalConditionId");

                    b.HasIndex("MedicineId");

                    b.ToTable("MedicineHasIncompatibleMedicalConditions");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.PrescriptionItems.PrescriptionItem", b =>
                {
                    b.HasBaseType("ComponentsLibrary.Entities.Item");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("PrescriptionItem");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.TherapySession", b =>
                {
                    b.HasBaseType("ComponentsLibrary.Entities.Item");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.Property<int?>("TherapistId")
                        .HasColumnType("int");

                    b.HasIndex("PatientId");

                    b.HasIndex("TherapistId");

                    b.ToTable("TherapySession");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.TherapySessionHasTreatments", b =>
                {
                    b.HasBaseType("ComponentsLibrary.Entities.Item");

                    b.Property<bool>("CompletedTreatment")
                        .HasColumnType("bit");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TherapySessionId")
                        .HasColumnType("int");

                    b.Property<int?>("TreatmentId")
                        .HasColumnType("int");

                    b.HasIndex("TherapySessionId");

                    b.HasIndex("TreatmentId");

                    b.ToTable("TherapySessionHasTreatments");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.User", b =>
                {
                    b.HasBaseType("ComponentsLibrary.Entities.Item");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HealthUserNumber")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.PrescriptionItems.Exercise", b =>
                {
                    b.HasBaseType("ComponentsLibrary.Entities.PrescriptionItems.PrescriptionItem");

                    b.Property<int>("AgeMaximum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(150);

                    b.Property<int>("AgeMinimum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.ToTable("Exercise");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.PrescriptionItems.Medicine", b =>
                {
                    b.HasBaseType("ComponentsLibrary.Entities.PrescriptionItems.PrescriptionItem");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.ToTable("Medicine");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.PrescriptionItems.Treatment", b =>
                {
                    b.HasBaseType("ComponentsLibrary.Entities.PrescriptionItems.PrescriptionItem");

                    b.Property<int>("AgeMaximum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(150);

                    b.Property<int>("AgeMinimum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("BodyPart")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.ToTable("Treatment");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.HealthCareProfessional", b =>
                {
                    b.HasBaseType("ComponentsLibrary.Entities.User");

                    b.ToTable("HealthCareProfessional");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.Patient", b =>
                {
                    b.HasBaseType("ComponentsLibrary.Entities.User");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.Therapist", b =>
                {
                    b.HasBaseType("ComponentsLibrary.Entities.HealthCareProfessional");

                    b.ToTable("Therapist");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.MedicalCondition", b =>
                {
                    b.HasOne("ComponentsLibrary.Entities.Item", null)
                        .WithOne()
                        .HasForeignKey("ComponentsLibrary.Entities.MedicalCondition", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.Prescription", b =>
                {
                    b.HasOne("ComponentsLibrary.Entities.HealthCareProfessional", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("ComponentsLibrary.Entities.Item", null)
                        .WithOne()
                        .HasForeignKey("ComponentsLibrary.Entities.Prescription", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("ComponentsLibrary.Entities.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId");

                    b.Navigation("Author");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.PrescriptionHasPrescriptionItems", b =>
                {
                    b.HasOne("ComponentsLibrary.Entities.Item", null)
                        .WithOne()
                        .HasForeignKey("ComponentsLibrary.Entities.PrescriptionHasPrescriptionItems", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("ComponentsLibrary.Entities.Prescription", "Prescription")
                        .WithMany()
                        .HasForeignKey("PrescriptionId");

                    b.HasOne("ComponentsLibrary.Entities.PrescriptionItems.PrescriptionItem", "PrescriptionItem")
                        .WithMany()
                        .HasForeignKey("PrescriptionItemId");

                    b.Navigation("Prescription");

                    b.Navigation("PrescriptionItem");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.PrescriptionHasViewers", b =>
                {
                    b.HasOne("ComponentsLibrary.Entities.HealthCareProfessional", "HealthCareProfessional")
                        .WithMany()
                        .HasForeignKey("HealthCareProfessionalId");

                    b.HasOne("ComponentsLibrary.Entities.Item", null)
                        .WithOne()
                        .HasForeignKey("ComponentsLibrary.Entities.PrescriptionHasViewers", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("ComponentsLibrary.Entities.Prescription", "Prescription")
                        .WithMany()
                        .HasForeignKey("PrescriptionId");

                    b.Navigation("HealthCareProfessional");

                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.PrescriptionItems.ExerciseHasBodyParts", b =>
                {
                    b.HasOne("ComponentsLibrary.Entities.PrescriptionItems.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseId");

                    b.HasOne("ComponentsLibrary.Entities.Item", null)
                        .WithOne()
                        .HasForeignKey("ComponentsLibrary.Entities.PrescriptionItems.ExerciseHasBodyParts", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Exercise");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.PrescriptionItems.MedicineHasIncompatibleMedicalConditions", b =>
                {
                    b.HasOne("ComponentsLibrary.Entities.Item", null)
                        .WithOne()
                        .HasForeignKey("ComponentsLibrary.Entities.PrescriptionItems.MedicineHasIncompatibleMedicalConditions", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("ComponentsLibrary.Entities.MedicalCondition", "MedicalCondition")
                        .WithMany()
                        .HasForeignKey("MedicalConditionId");

                    b.HasOne("ComponentsLibrary.Entities.PrescriptionItems.Medicine", "Medicine")
                        .WithMany()
                        .HasForeignKey("MedicineId");

                    b.Navigation("MedicalCondition");

                    b.Navigation("Medicine");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.PrescriptionItems.PrescriptionItem", b =>
                {
                    b.HasOne("ComponentsLibrary.Entities.Item", null)
                        .WithOne()
                        .HasForeignKey("ComponentsLibrary.Entities.PrescriptionItems.PrescriptionItem", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.TherapySession", b =>
                {
                    b.HasOne("ComponentsLibrary.Entities.Item", null)
                        .WithOne()
                        .HasForeignKey("ComponentsLibrary.Entities.TherapySession", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("ComponentsLibrary.Entities.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId");

                    b.HasOne("ComponentsLibrary.Entities.Therapist", "Therapist")
                        .WithMany()
                        .HasForeignKey("TherapistId");

                    b.Navigation("Patient");

                    b.Navigation("Therapist");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.TherapySessionHasTreatments", b =>
                {
                    b.HasOne("ComponentsLibrary.Entities.Item", null)
                        .WithOne()
                        .HasForeignKey("ComponentsLibrary.Entities.TherapySessionHasTreatments", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("ComponentsLibrary.Entities.TherapySession", "TherapySession")
                        .WithMany()
                        .HasForeignKey("TherapySessionId");

                    b.HasOne("ComponentsLibrary.Entities.PrescriptionItems.Treatment", "Treatment")
                        .WithMany()
                        .HasForeignKey("TreatmentId");

                    b.Navigation("TherapySession");

                    b.Navigation("Treatment");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.User", b =>
                {
                    b.HasOne("ComponentsLibrary.Entities.Item", null)
                        .WithOne()
                        .HasForeignKey("ComponentsLibrary.Entities.User", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.PrescriptionItems.Exercise", b =>
                {
                    b.HasOne("ComponentsLibrary.Entities.PrescriptionItems.PrescriptionItem", null)
                        .WithOne()
                        .HasForeignKey("ComponentsLibrary.Entities.PrescriptionItems.Exercise", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.PrescriptionItems.Medicine", b =>
                {
                    b.HasOne("ComponentsLibrary.Entities.PrescriptionItems.PrescriptionItem", null)
                        .WithOne()
                        .HasForeignKey("ComponentsLibrary.Entities.PrescriptionItems.Medicine", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.PrescriptionItems.Treatment", b =>
                {
                    b.HasOne("ComponentsLibrary.Entities.PrescriptionItems.PrescriptionItem", null)
                        .WithOne()
                        .HasForeignKey("ComponentsLibrary.Entities.PrescriptionItems.Treatment", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.HealthCareProfessional", b =>
                {
                    b.HasOne("ComponentsLibrary.Entities.User", null)
                        .WithOne()
                        .HasForeignKey("ComponentsLibrary.Entities.HealthCareProfessional", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.Patient", b =>
                {
                    b.HasOne("ComponentsLibrary.Entities.User", null)
                        .WithOne()
                        .HasForeignKey("ComponentsLibrary.Entities.Patient", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.Therapist", b =>
                {
                    b.HasOne("ComponentsLibrary.Entities.HealthCareProfessional", null)
                        .WithOne()
                        .HasForeignKey("ComponentsLibrary.Entities.Therapist", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
