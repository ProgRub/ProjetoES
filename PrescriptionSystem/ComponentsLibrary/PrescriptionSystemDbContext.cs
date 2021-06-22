using System;
using System.Collections.Generic;
using System.Linq;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using Microsoft.EntityFrameworkCore;

namespace ComponentsLibrary
{
    public class PrescriptionSystemDbContext : DbContext
    {
        #region Constants

        public const int Allergy = 0, Disease = 1;

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PrescriptionSystemDb;MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            TablesConfiguration(modelBuilder);

            PropertiesConfiguration(modelBuilder);

            ManyToManyTablesConfiguration(modelBuilder);

            SeedData(modelBuilder);

            ConvertersConfiguration(modelBuilder);
        }

        private void TablesConfiguration(ModelBuilder modelBuilder)
        {
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
            modelBuilder.Entity<MedicineHasIncompatibleMedicalConditions>()
                .ToTable("MedicineHasIncompatibleMedicalConditions");
            modelBuilder.Entity<PrescriptionHasPrescriptionItems>().ToTable("PrescriptionHasPrescriptionItems");
            modelBuilder.Entity<PrescriptionHasViewers>().ToTable("PrescriptionHasViewers");
            modelBuilder.Entity<TherapySessionHasTreatments>().ToTable("TherapySessionHasTreatments");
            modelBuilder.Entity<UserHasMedicalCondition>().ToTable("UserHasMedicalCondition");
        }

        private void PropertiesConfiguration(ModelBuilder modelBuilder)
        {
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

            modelBuilder.Entity<TherapySession>().Property(e => e.DateTime).IsRequired();

            modelBuilder.Entity<PrescriptionItem>().Property(e => e.Name).IsRequired();
            modelBuilder.Entity<Medicine>().Property(e => e.Price).IsRequired();
            modelBuilder.Entity<Treatment>().Property(e => e.Duration).IsRequired();
            modelBuilder.Entity<Treatment>().Property(e => e.AgeMaximum).IsRequired().HasDefaultValue(150);
            modelBuilder.Entity<Treatment>().Property(e => e.AgeMinimum).IsRequired().HasDefaultValue(0);
            modelBuilder.Entity<Treatment>().Property(e => e.BodyPart).IsRequired();
            modelBuilder.Entity<Exercise>().Property(e => e.AgeMaximum).IsRequired().HasDefaultValue(150);
            modelBuilder.Entity<Exercise>().Property(e => e.AgeMinimum).IsRequired().HasDefaultValue(0);
            modelBuilder.Entity<Exercise>().Property(e => e.Duration).IsRequired();

            //modelBuilder.Entity<TherapySession>().HasOne<Patient>().WithOne().HasForeignKey<Patient>(e => e.Id);
            //modelBuilder.Entity<TherapySession>().HasOne<Therapist>().WithOne().HasForeignKey<Therapist>(e => e.Id);
        }

        private void ManyToManyTablesConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MedicineHasIncompatibleMedicalConditions>().Property(e => e.Zombie)
                .HasDefaultValue(false);
            modelBuilder.Entity<MedicineHasIncompatibleMedicalConditions>().Property(e => e.TimeStamp)
                .IsConcurrencyToken().ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<MedicineHasIncompatibleMedicalConditions>()
                .HasKey(e => new {e.MedicineId, e.MedicalConditionId});
            modelBuilder.Entity<PrescriptionHasViewers>().Property(e => e.Zombie).HasDefaultValue(false);
            modelBuilder.Entity<PrescriptionHasViewers>().Property(e => e.TimeStamp).IsConcurrencyToken()
                .ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<PrescriptionHasViewers>()
                .HasKey(e => new {e.HealthCareProfessionalId, e.PrescriptionId});
            modelBuilder.Entity<PrescriptionHasPrescriptionItems>().Property(e => e.Zombie).HasDefaultValue(false);
            modelBuilder.Entity<PrescriptionHasPrescriptionItems>().Property(e => e.TimeStamp).IsConcurrencyToken()
                .ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<PrescriptionHasPrescriptionItems>()
                .HasKey(e => new {e.PrescriptionId, e.PrescriptionItemId});
            modelBuilder.Entity<TherapySessionHasTreatments>().Property(e => e.Zombie).HasDefaultValue(false);
            modelBuilder.Entity<TherapySessionHasTreatments>().Property(e => e.TimeStamp).IsConcurrencyToken()
                .ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<TherapySessionHasTreatments>()
                .HasKey(e => new {e.TherapySessionId, e.TreatmentId});
            modelBuilder.Entity<UserHasMedicalCondition>().Property(e => e.Zombie).HasDefaultValue(false);
            modelBuilder.Entity<UserHasMedicalCondition>().Property(e => e.TimeStamp).IsConcurrencyToken()
                .ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<UserHasMedicalCondition>()
                .HasKey(e => new {e.MedicalConditionId, e.UserId});
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            var id = 1;
            modelBuilder.Entity<Medicine>().HasData(
                new Medicine {Id = id++, Zombie = false, Name = "Penicillin", Description = "", Price = 2.32},
                new Medicine {Id = id++, Zombie = false, Name = "Streptomycin", Description = "", Price = 4.57},
                new Medicine {Id = id++, Zombie = false, Name = "Pyrazolones", Description = "", Price = 12.40});
            modelBuilder.Entity<Treatment>().HasData(
                new Treatment
                {
                    Id = id++,
                    Zombie = false,
                    Name = "Torn Triceps",
                    Description = "Treatment given to people with torn triceps on their right arm",
                    BodyPart = BodyPart.RightArm, Duration = new TimeSpan(0, 30, 0)
                },
                new Treatment
                {
                    Id = id++,
                    Zombie = false,
                    Name = "Torn Triceps",
                    Description = "Treatment given to people with torn triceps on their left arm",
                    BodyPart = BodyPart.LeftArm,
                    Duration = new TimeSpan(0, 30, 0)
                },
                new Treatment
                {
                    Id = id++,
                    Zombie = false,
                    Name = "Hyper-extended Knee", Description = "An ice pack is needed for this treatment",
                    BodyPart = BodyPart.LeftLeg, Duration = new TimeSpan(1, 0, 0)
                },
                new Treatment
                {
                    Id = id++,
                    Zombie = false,
                    Name = "Hyper-extended Knee",
                    Description = "An ice pack is needed for this treatment",
                    BodyPart = BodyPart.RightLeg,
                    Duration = new TimeSpan(1, 0, 0)
                });
            modelBuilder.Entity<Exercise>().HasData(new Exercise
            {
                Id = id++,
                Zombie = false,
                Name = "Burpees",
                AgeMinimum = 15,
                AgeMaximum = 50,
                Description =
                    "From standing up, drop into a high plank and then jump your feet to your hands, stand up and jump with your arms up. Repeat.",
                Duration = new TimeSpan(0, 10, 0),
                BodyParts = new List<BodyPart>
                    {BodyPart.RightArm, BodyPart.LeftArm, BodyPart.LeftLeg, BodyPart.RightLeg}
            }, new Exercise
            {
                Id = id++,
                Zombie = false,
                Name = "Pushups",
                AgeMinimum = 8,
                AgeMaximum = 78,
                Description = "",
                Duration = new TimeSpan(0, 20, 0),
                BodyParts = new List<BodyPart> {BodyPart.RightArm, BodyPart.LeftArm, BodyPart.Torso}
            }, new Exercise
            {
                Id = id++,
                Zombie = false,
                Name = "Squats",
                AgeMinimum = 5,
                Description = "Make sure your knees don't go in front of your feet",
                Duration = new TimeSpan(0, 15, 0),
                BodyParts = new List<BodyPart> {BodyPart.RightLeg, BodyPart.LeftLeg}
            });
            modelBuilder.Entity<MedicalCondition>().HasData(new MedicalCondition
            {
                Id = id++,
                Zombie = false,
                Name = "Penicillin", Description = "", Type = Allergy
            }, new MedicalCondition
            {
                Id = id++,
                Zombie = false,
                Name = "Aspirin",
                Description = "",
                Type = Allergy
            }, new MedicalCondition
            {
                Id = id++,
                Zombie = false,
                Name = "Ibuprofen",
                Description = "",
                Type = Allergy
            }, new MedicalCondition
            {
                Id = id++,
                Zombie = false,
                Name = "Hypertension",
                Description = "",
                Type = Disease
            }, new MedicalCondition
            {
                Id = id++,
                Zombie = false,
                Name = "Knee Osteoarthritis",
                Description = "This type of arthritis affects specifically the knees",
                Type = Disease
            });
            modelBuilder.Entity<Patient>().HasData(new Patient
            {
                Id = id++,
                Zombie = false,
                FullName = "Luís Brito",
                DateOfBirth = new DateTime(1985, 10, 4),
                PhoneNumber = 924837193,
                HealthUserNumber = 243719236,
                Email = "luisbrito@gmail.com",
                Password = "luis123",
                MissingBodyParts = new List<BodyPart> {BodyPart.RightArm}
            }, new Patient
            {
                Id = id++,
                Zombie = false,
                FullName = "Mariana Abreu",
                DateOfBirth = new DateTime(1994, 6, 19),
                PhoneNumber = 968391023,
                HealthUserNumber = 295831023,
                Email = "marybreu@hotmail.com",
                Password = "M_A_R_Y",
                MissingBodyParts = new List<BodyPart> { BodyPart.LeftLeg }
            });

            modelBuilder.Entity<Therapist>().HasData(new Therapist
            {
                Id = id++,
                Zombie = false,
                FullName = "Carla Nunes",
                DateOfBirth = new DateTime(1975, 5, 2),
                PhoneNumber = 917009283,
                HealthUserNumber = 291039113,
                Email = "carlanunes1975@hotmail.com",
                Password = "carlaaa"
            }, new Therapist
            {
                Id = id++,
                Zombie = false,
                FullName = "Rui Nóbrega",
                DateOfBirth = new DateTime(1958, 11, 13),
                PhoneNumber = 969070184,
                HealthUserNumber = 200192356,
                Email = "nobregarui@hotmail.com",
                Password = "ruiruirui"
            });
        }

        private void ConvertersConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<PrescriptionHasPrescriptionItems>()
                .Property(e => e.RecommendedTimes)
                .HasConversion(v => string.Join(',', v.Select(e => e.ToString(@"hh\:mm")).ToArray()),
                    v => v.Split(new[] {','})
                        .Select(e => TimeSpan.Parse(e))
                        .ToList());

            modelBuilder
                .Entity<User>()
                .Property(e => e.MissingBodyParts)
                .HasConversion(
                    v => string.Join(',', v.Select(e => e.ToString("D")).ToArray()),
                    v => v.Split(new[] {','})
                        .Select(e => Enum.Parse(typeof(BodyPart), e))
                        .Cast<BodyPart>()
                        .ToList()
                );

            modelBuilder
                .Entity<Exercise>()
                .Property(e => e.BodyParts)
                .HasConversion(
                    v => string.Join(',', v.Select(e => e.ToString("D")).ToArray()),
                    v => v.Split(new[] {','})
                        .Select(e => Enum.Parse(typeof(BodyPart), e))
                        .Cast<BodyPart>()
                        .ToList()
                );
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

        public DbSet<MedicineHasIncompatibleMedicalConditions> MedicineHasIncompatibleMedicalConditionsEnumerable
        {
            get;
            set;
        }

        public DbSet<PrescriptionHasPrescriptionItems> PrescriptionHasPrescriptionItemsEnumerable { get; set; }
        public DbSet<PrescriptionHasViewers> PrescriptionHasViewersEnumerable { get; set; }
        public DbSet<TherapySessionHasTreatments> TherapySessionHasTreatmentsEnumerable { get; set; }
        public DbSet<UserHasMedicalCondition> UserHasMedicalConditionsEnumerable { get; set; }

        //Comando na Package Manager Console para adicionar modificações no contexto à DB => Add-Migration 
        //Comando na Package Manager Console para atualizar DB => Update-Database
    }
}