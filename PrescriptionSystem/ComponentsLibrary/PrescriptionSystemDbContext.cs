using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using Microsoft.EntityFrameworkCore;

namespace ComponentsLibrary
{
    public class PrescriptionSystemDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=PrescriptionSystemDb");
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
            modelBuilder.Entity<Item>().Property(e => e.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Item>().Property(e => e.Zombie).HasDefaultValue(false);
            modelBuilder.Entity<Item>().Property(e => e.TimeStamp).IsConcurrencyToken().ValueGeneratedOnAddOrUpdate();
        }

        //Comando para adiconar alterações no context à DB na Package Manager Console  => Add-Migration 
        //Commando para atualizar DB => Update-Database
    }
}