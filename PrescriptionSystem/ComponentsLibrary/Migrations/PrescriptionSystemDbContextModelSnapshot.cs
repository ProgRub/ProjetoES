﻿// <auto-generated />
using System;
using ComponentsLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ComponentsLibrary.Migrations
{
    [DbContext(typeof(PrescriptionSystemDbContext))]
    partial class PrescriptionSystemDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("ComponentsLibrary.Entities.PrescriptionHasPrescriptionItems", b =>
                {
                    b.Property<int>("PrescriptionId")
                        .HasColumnType("int");

                    b.Property<int>("PrescriptionItemId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("RecommendedTime")
                        .HasColumnType("time");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<bool>("Zombie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("PrescriptionId", "PrescriptionItemId");

                    b.HasIndex("PrescriptionItemId");

                    b.ToTable("PrescriptionHasPrescriptionItems");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.PrescriptionHasViewers", b =>
                {
                    b.Property<int>("HealthCareProfessionalId")
                        .HasColumnType("int");

                    b.Property<int>("PrescriptionId")
                        .HasColumnType("int");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<bool>("Zombie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("HealthCareProfessionalId", "PrescriptionId");

                    b.HasIndex("PrescriptionId");

                    b.ToTable("PrescriptionHasViewers");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.PrescriptionItems.MedicineHasIncompatibleMedicalConditions", b =>
                {
                    b.Property<int>("MedicineId")
                        .HasColumnType("int");

                    b.Property<int>("MedicalConditionId")
                        .HasColumnType("int");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<bool>("Zombie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("MedicineId", "MedicalConditionId");

                    b.HasIndex("MedicalConditionId");

                    b.ToTable("MedicineHasIncompatibleMedicalConditions");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.TherapySessionHasTreatments", b =>
                {
                    b.Property<int>("TherapySessionId")
                        .HasColumnType("int");

                    b.Property<int>("TreatmentId")
                        .HasColumnType("int");

                    b.Property<bool>("CompletedTreatment")
                        .HasColumnType("bit");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<bool>("Zombie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("TherapySessionId", "TreatmentId");

                    b.HasIndex("TreatmentId");

                    b.ToTable("TherapySessionHasTreatments");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.UserHasMedicalCondition", b =>
                {
                    b.Property<int>("MedicalConditionId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<bool>("Zombie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("MedicalConditionId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserHasMedicalCondition");
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

                    b.HasData(
                        new
                        {
                            Id = 11,
                            Zombie = false,
                            Description = "",
                            Name = "Penicillin",
                            Type = 0
                        },
                        new
                        {
                            Id = 12,
                            Zombie = false,
                            Description = "",
                            Name = "Aspirin",
                            Type = 0
                        },
                        new
                        {
                            Id = 13,
                            Zombie = false,
                            Description = "",
                            Name = "Ibuprofen",
                            Type = 0
                        },
                        new
                        {
                            Id = 14,
                            Zombie = false,
                            Description = "",
                            Name = "Hypertension",
                            Type = 1
                        },
                        new
                        {
                            Id = 15,
                            Zombie = false,
                            Description = "This type of arthritis affects specifically the knees",
                            Name = "Knee Osteoarthritis",
                            Type = 1
                        });
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

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("EstimatedDuration")
                        .HasColumnType("time");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("TherapistId")
                        .HasColumnType("int");

                    b.HasIndex("PatientId");

                    b.HasIndex("TherapistId");

                    b.ToTable("TherapySession");
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

            modelBuilder.Entity("ComponentsLibrary.Entities.UserHasMissingBodyPart", b =>
                {
                    b.HasBaseType("ComponentsLibrary.Entities.Item");

                    b.Property<int>("BodyPart")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasIndex("UserId");

                    b.ToTable("UserHasMissingBodyPart");
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

                    b.HasData(
                        new
                        {
                            Id = 8,
                            Zombie = false,
                            Description = "From standing up, drop into a high plank and then jump your feet to your hands, stand up and jump with your arms up. Repeat.",
                            Name = "Burpees",
                            AgeMaximum = 50,
                            AgeMinimum = 15,
                            Duration = new TimeSpan(0, 0, 10, 0, 0)
                        },
                        new
                        {
                            Id = 9,
                            Zombie = false,
                            Description = "",
                            Name = "Pushups",
                            AgeMaximum = 78,
                            AgeMinimum = 8,
                            Duration = new TimeSpan(0, 0, 20, 0, 0)
                        },
                        new
                        {
                            Id = 10,
                            Zombie = false,
                            Description = "Make sure your knees don't go in front of your feet",
                            Name = "Squats",
                            AgeMaximum = 0,
                            AgeMinimum = 5,
                            Duration = new TimeSpan(0, 0, 15, 0, 0)
                        });
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.PrescriptionItems.Medicine", b =>
                {
                    b.HasBaseType("ComponentsLibrary.Entities.PrescriptionItems.PrescriptionItem");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.ToTable("Medicine");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Zombie = false,
                            Description = "",
                            Name = "Penicillin",
                            Price = 2.3199999999999998
                        },
                        new
                        {
                            Id = 2,
                            Zombie = false,
                            Description = "",
                            Name = "Streptomycin",
                            Price = 4.5700000000000003
                        },
                        new
                        {
                            Id = 3,
                            Zombie = false,
                            Description = "",
                            Name = "Pyrazolones",
                            Price = 12.4
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 4,
                            Zombie = false,
                            Description = "Treatment given to people with torn triceps on their right arm",
                            Name = "Torn Triceps",
                            AgeMaximum = 0,
                            AgeMinimum = 0,
                            BodyPart = 3,
                            Duration = new TimeSpan(0, 0, 30, 0, 0)
                        },
                        new
                        {
                            Id = 5,
                            Zombie = false,
                            Description = "Treatment given to people with torn triceps on their left arm",
                            Name = "Torn Triceps",
                            AgeMaximum = 0,
                            AgeMinimum = 0,
                            BodyPart = 2,
                            Duration = new TimeSpan(0, 0, 30, 0, 0)
                        },
                        new
                        {
                            Id = 6,
                            Zombie = false,
                            Description = "An ice pack is needed for this treatment",
                            Name = "Hyper-extended Knee",
                            AgeMaximum = 0,
                            AgeMinimum = 0,
                            BodyPart = 4,
                            Duration = new TimeSpan(0, 1, 0, 0, 0)
                        },
                        new
                        {
                            Id = 7,
                            Zombie = false,
                            Description = "An ice pack is needed for this treatment",
                            Name = "Hyper-extended Knee",
                            AgeMaximum = 0,
                            AgeMinimum = 0,
                            BodyPart = 5,
                            Duration = new TimeSpan(0, 1, 0, 0, 0)
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 16,
                            Zombie = false,
                            DateOfBirth = new DateTime(1985, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "luisbrito@gmail.com",
                            FullName = "Luís Brito",
                            HealthUserNumber = 243719236,
                            Password = "luis123",
                            PhoneNumber = 924837193
                        },
                        new
                        {
                            Id = 17,
                            Zombie = false,
                            DateOfBirth = new DateTime(1994, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "marybreu@hotmail.com",
                            FullName = "Mariana Abreu",
                            HealthUserNumber = 295831023,
                            Password = "M_A_R_Y",
                            PhoneNumber = 968391023
                        });
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.Therapist", b =>
                {
                    b.HasBaseType("ComponentsLibrary.Entities.HealthCareProfessional");

                    b.ToTable("Therapist");

                    b.HasData(
                        new
                        {
                            Id = 18,
                            Zombie = false,
                            DateOfBirth = new DateTime(1975, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "carlanunes1975@hotmail.com",
                            FullName = "Carla Nunes",
                            HealthUserNumber = 291039113,
                            Password = "carlaaa",
                            PhoneNumber = 917009283
                        },
                        new
                        {
                            Id = 19,
                            Zombie = false,
                            DateOfBirth = new DateTime(1958, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "nobregarui@hotmail.com",
                            FullName = "Rui Nóbrega",
                            HealthUserNumber = 200192356,
                            Password = "ruiruirui",
                            PhoneNumber = 969070184
                        });
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.PrescriptionHasPrescriptionItems", b =>
                {
                    b.HasOne("ComponentsLibrary.Entities.Prescription", "Prescription")
                        .WithMany("PrescriptionHasPrescriptionItemsCollection")
                        .HasForeignKey("PrescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ComponentsLibrary.Entities.PrescriptionItems.PrescriptionItem", "PrescriptionItem")
                        .WithMany("PrescriptionHasPrescriptionItemsCollection")
                        .HasForeignKey("PrescriptionItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prescription");

                    b.Navigation("PrescriptionItem");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.PrescriptionHasViewers", b =>
                {
                    b.HasOne("ComponentsLibrary.Entities.HealthCareProfessional", "HealthCareProfessional")
                        .WithMany("PrescriptionHasViewersCollection")
                        .HasForeignKey("HealthCareProfessionalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ComponentsLibrary.Entities.Prescription", "Prescription")
                        .WithMany("PrescriptionHasViewersCollection")
                        .HasForeignKey("PrescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HealthCareProfessional");

                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.PrescriptionItems.MedicineHasIncompatibleMedicalConditions", b =>
                {
                    b.HasOne("ComponentsLibrary.Entities.MedicalCondition", "MedicalCondition")
                        .WithMany("MedicineHasIncompatibleMedicalConditionsList")
                        .HasForeignKey("MedicalConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ComponentsLibrary.Entities.PrescriptionItems.Medicine", "Medicine")
                        .WithMany("MedicineHasIncompatibleMedicalConditionsList")
                        .HasForeignKey("MedicineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MedicalCondition");

                    b.Navigation("Medicine");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.TherapySessionHasTreatments", b =>
                {
                    b.HasOne("ComponentsLibrary.Entities.TherapySession", "TherapySession")
                        .WithMany("TherapySessionHasTreatmentsCollection")
                        .HasForeignKey("TherapySessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ComponentsLibrary.Entities.PrescriptionItems.Treatment", "Treatment")
                        .WithMany("TherapySessionHasTreatmentsCollection")
                        .HasForeignKey("TreatmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TherapySession");

                    b.Navigation("Treatment");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.UserHasMedicalCondition", b =>
                {
                    b.HasOne("ComponentsLibrary.Entities.MedicalCondition", "MedicalCondition")
                        .WithMany("UserHasMedicalConditions")
                        .HasForeignKey("MedicalConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ComponentsLibrary.Entities.User", "User")
                        .WithMany("UserHasMedicalConditions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MedicalCondition");

                    b.Navigation("User");
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
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ComponentsLibrary.Entities.Therapist", "Therapist")
                        .WithMany()
                        .HasForeignKey("TherapistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");

                    b.Navigation("Therapist");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.User", b =>
                {
                    b.HasOne("ComponentsLibrary.Entities.Item", null)
                        .WithOne()
                        .HasForeignKey("ComponentsLibrary.Entities.User", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.UserHasMissingBodyPart", b =>
                {
                    b.HasOne("ComponentsLibrary.Entities.Item", null)
                        .WithOne()
                        .HasForeignKey("ComponentsLibrary.Entities.UserHasMissingBodyPart", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("ComponentsLibrary.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
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

            modelBuilder.Entity("ComponentsLibrary.Entities.MedicalCondition", b =>
                {
                    b.Navigation("MedicineHasIncompatibleMedicalConditionsList");

                    b.Navigation("UserHasMedicalConditions");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.Prescription", b =>
                {
                    b.Navigation("PrescriptionHasPrescriptionItemsCollection");

                    b.Navigation("PrescriptionHasViewersCollection");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.PrescriptionItems.PrescriptionItem", b =>
                {
                    b.Navigation("PrescriptionHasPrescriptionItemsCollection");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.TherapySession", b =>
                {
                    b.Navigation("TherapySessionHasTreatmentsCollection");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.User", b =>
                {
                    b.Navigation("UserHasMedicalConditions");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.PrescriptionItems.Medicine", b =>
                {
                    b.Navigation("MedicineHasIncompatibleMedicalConditionsList");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.PrescriptionItems.Treatment", b =>
                {
                    b.Navigation("TherapySessionHasTreatmentsCollection");
                });

            modelBuilder.Entity("ComponentsLibrary.Entities.HealthCareProfessional", b =>
                {
                    b.Navigation("PrescriptionHasViewersCollection");
                });
#pragma warning restore 612, 618
        }
    }
}
