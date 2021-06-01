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
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PrescriptionSystemDB");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Tables
            modelBuilder.Entity<Item>().ToTable("Item");
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
            modelBuilder.Entity<MedicineHasIncompatibleMedicalConditions>().ToTable("MedicineHasIncompatibleMedicalConditions");
            modelBuilder.Entity<PrescriptionHasPrescriptionItems>().ToTable("PrescriptionHasPrescriptionItems");
            modelBuilder.Entity<PrescriptionHasViewers>().ToTable("PrescriptionHasViewers");
            modelBuilder.Entity<TherapySessionHasTreatments>().ToTable("TherapySessionHasTreatments");


            modelBuilder.Entity<Item>().Property(e => e.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Item>().Property(e => e.Zombie).HasDefaultValue(false);
            modelBuilder.Entity<Item>().Property(e => e.TimeStamp).IsConcurrencyToken().ValueGeneratedOnAddOrUpdate();

            
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
        public DbSet<MedicineHasIncompatibleMedicalConditions> MedicineHasIncompatibleMedicalConditionsEnumerable { get; set; }
        public DbSet<PrescriptionHasPrescriptionItems> PrescriptionHasPrescriptionItemsEnumerable { get; set; }
        public DbSet<PrescriptionHasViewers> PrescriptionHasViewersEnumerable { get; set; }
        public DbSet<TherapySessionHasTreatments> TherapySessionHasTreatmentsEnumerable { get; set; }

        //Command on Package Manager Console => Add-Migration 
    }
}