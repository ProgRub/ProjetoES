using System;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using Microsoft.EntityFrameworkCore;

namespace ComponentsLibrary
{
    public class PrescriptionSystemDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PrescriptionSystemDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Tables

            modelBuilder.Entity<Item>().ToTable("Item");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Patient>().ToTable("Patient");
            modelBuilder.Entity<HealthCareProfessional>().ToTable("HealthCareProfessional");
            modelBuilder.Entity<Therapist>().ToTable("Therapist");
            modelBuilder.Entity<MedicalCondition>().ToTable("MedicalCondition");
            modelBuilder.Entity<PrescriptionItem>().ToTable("PrescriptionItem");
            modelBuilder.Entity<Medicine>().ToTable("Medicine");
            modelBuilder.Entity<Treatment>().ToTable("Treatment");
            modelBuilder.Entity<TherapySession>().ToTable("TherapySession");
            modelBuilder.Entity<Prescription>().ToTable("Prescription");
            modelBuilder.Entity<Exercise>().ToTable("Exercise");
            modelBuilder.Entity<ExerciseHasBodyParts>().ToTable("ExerciseHasBodyParts");
            modelBuilder.Entity<MedicineHasIncompatibleMedicalConditions>()
                .ToTable("MedicineHasIncompatibleMedicalConditions");
            modelBuilder.Entity<PrescriptionHasPrescriptionItems>().ToTable("PrescriptionHasPrescriptionItems");
            modelBuilder.Entity<PrescriptionHasViewers>().ToTable("PrescriptionHasViewers");
            modelBuilder.Entity<TherapySessionHasTreatments>().ToTable("TherapySessionHasTreatments");

            #endregion

            #region Properties Config

            modelBuilder.Entity<Item>().Property(e => e.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Item>().Property(e => e.Zombie).HasDefaultValue(false);
            modelBuilder.Entity<Item>().Property(e => e.TimeStamp).IsConcurrencyToken().ValueGeneratedOnAddOrUpdate();

            modelBuilder.Entity<User>().Property(e => e.FullName).IsRequired();
            modelBuilder.Entity<User>().Property(e => e.DateOfBirth).IsRequired();
            modelBuilder.Entity<User>().Property(e => e.Email).IsRequired();
            modelBuilder.Entity<User>().Property(e => e.HealthUserNumber).IsRequired();
            modelBuilder.Entity<User>().Property(e => e.Password).IsRequired();
            modelBuilder.Entity<User>().Property(e => e.PhoneNumber).IsRequired();

            modelBuilder.Entity<Prescription>().Property(e => e.EndDate).IsRequired();
            modelBuilder.Entity<Prescription>().Property(e => e.StartDate).IsRequired();

            modelBuilder.Entity<TherapySession>().Property(e => e.Date).IsRequired();

            modelBuilder.Entity<PrescriptionItem>().Property(e => e.Name).IsRequired();
            modelBuilder.Entity<Medicine>().Property(e => e.Price).IsRequired();
            modelBuilder.Entity<Treatment>().Property(e => e.Duration).IsRequired();
            modelBuilder.Entity<Treatment>().Property(e => e.AgeMaximum).IsRequired().HasDefaultValue(150);
            modelBuilder.Entity<Treatment>().Property(e => e.AgeMinimum).IsRequired().HasDefaultValue(0);
            modelBuilder.Entity<Treatment>().Property(e => e.BodyPart).IsRequired();
            modelBuilder.Entity<Exercise>().Property(e => e.AgeMaximum).IsRequired().HasDefaultValue(150);
            modelBuilder.Entity<Exercise>().Property(e => e.AgeMinimum).IsRequired().HasDefaultValue(0);
            modelBuilder.Entity<Exercise>().Property(e => e.Duration).IsRequired();

            #endregion

            #region Initial Data

            modelBuilder.Entity<Medicine>().HasData(new Medicine {Id = 1,Zombie = false,Name = "Penicillin", Description = "", Price = 2.32},
                new Medicine { Id = 2, Zombie = false, Name = "Streptomycin", Description = "", Price = 4.57},
                new Medicine { Id = 3, Zombie = false, Name = "Pyrazolones", Description = "", Price = 12.40});
            modelBuilder.Entity<Treatment>().HasData(
                new Treatment
                {
                    Id = 4,
                    Zombie = false,
                    Name = "Torn Triceps",
                    Description = "Treatment given to people with torn triceps on their right arm",
                    BodyPart = BodyPart.RightArm, Duration = new TimeSpan(0, 30, 0)
                },
                new Treatment
                {
                    Id = 5,
                    Zombie = false,
                    Name = "Torn Triceps",
                    Description = "Treatment given to people with torn triceps on their left arm",
                    BodyPart = BodyPart.LeftArm,
                    Duration = new TimeSpan(0, 30, 0)
                },
                new Treatment
                {
                    Id = 6,
                    Zombie = false,
                    Name = "Hyper-extended Knee", Description = "An ice pack is needed for this treatment",
                    BodyPart = BodyPart.LeftLeg, Duration = new TimeSpan(1, 0, 0)
                },
                new Treatment
                {
                    Id = 7,
                    Zombie = false,
                    Name = "Hyper-extended Knee",
                    Description = "An ice pack is needed for this treatment",
                    BodyPart = BodyPart.RightLeg,
                    Duration = new TimeSpan(1, 0, 0)
                });
            modelBuilder.Entity<Exercise>().HasData(new Exercise
            {
                Id = 8,
                Zombie = false,
                Name = "Burpees", AgeMinimum = 15, AgeMaximum = 50,
                Description =
                    "From standing up, drop into a high plank and then jump your feet to your hands, stand up and jump with your arms up. Repeat.",
                Duration = new TimeSpan(0, 10, 0)
            }, new Exercise
            {
                Id = 9,
                Zombie = false,
                Name = "Pushups",
                AgeMinimum = 8,
                AgeMaximum = 78,
                Description ="",
                Duration = new TimeSpan(0, 20, 0)
            }, new Exercise
            {
                Id = 10,
                Zombie = false,
                Name = "Squats",
                AgeMinimum = 5,
                Description = "Make sure your knees don't go in front of your feet",
                Duration = new TimeSpan(0, 15, 0)
            });

            #endregion
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<HealthCareProfessional> HealthCareProfessionals { get; set; }
        public DbSet<Therapist> Therapists { get; set; }
        public DbSet<MedicalCondition> MedicalConditions { get; set; }
        public DbSet<PrescriptionItem> PrescriptionItems { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
        public DbSet<TherapySession> TherapySessions { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExerciseHasBodyParts> ExerciseHasBodyPartsEnumerable { get; set; }

        public DbSet<MedicineHasIncompatibleMedicalConditions> MedicineHasIncompatibleMedicalConditionsEnumerable
        {
            get;
            set;
        }

        public DbSet<PrescriptionHasPrescriptionItems> PrescriptionHasPrescriptionItemsEnumerable { get; set; }
        public DbSet<PrescriptionHasViewers> PrescriptionHasViewersEnumerable { get; set; }
        public DbSet<TherapySessionHasTreatments> TherapySessionHasTreatmentsEnumerable { get; set; }

        //Comando na Package Manager Console para adicionar modificações no contexto à DB => Add-Migration 
        //Comando na Package Manager Console para atualizar DB => Update-Database
    }
}