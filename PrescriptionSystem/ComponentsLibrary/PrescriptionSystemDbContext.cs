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
            modelBuilder.Entity<MedicineHasIncompatibleMedicalConditions>().ToTable("MedicineHasIncompatibleMedicalConditions");
            modelBuilder.Entity<PrescriptionHasPrescriptionItems>().ToTable("PrescriptionHasPrescriptionItems");
            modelBuilder.Entity<PrescriptionHasViewers>().ToTable("PrescriptionHasViewers");
            modelBuilder.Entity<TherapySessionHasTreatments>().ToTable("TherapySessionHasTreatments");

            #endregion

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
            //modelBuilder.Entity<Prescription>().Property(e => e.Author).IsRequired();
            //modelBuilder.Entity<Prescription>().Property(e => e.Patient).IsRequired();
            
            //modelBuilder.Entity<TherapySession>().Property(e => e.Patient).IsRequired();
            //modelBuilder.Entity<TherapySession>().Property(e => e.Therapist).IsRequired();
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

        //Comando na Package Manager Console para adicionar modificações no contexto à DB => Add-Migration 
        //Comando na Package Manager Console para atualizar DB => Update-Database
    }
}