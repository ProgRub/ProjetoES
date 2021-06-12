using ComponentsLibrary;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using ComponentsLibrary.Repositories.Implementations;
using ComponentsLibrary.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServicesLibrary.DifferentServices
{
    public class PrescriptionItemService
    {
        private readonly IMedicineRepository _medicineRepository;
        private readonly IExerciseRepository _exerciseRepository;
        private readonly ITreatmentRepository _treatmentRepository;

        private PrescriptionItemService()
        {
            _medicineRepository = new MedicineRepository(Database.GetContext());
            _exerciseRepository = new ExerciseRepository(Database.GetContext());
            _treatmentRepository = new TreatmentRepository(Database.GetContext());
        }

        internal static PrescriptionItemService Instance { get; } = new PrescriptionItemService();

        internal void CreateExercisePrescriptionItem(string name, string description, int ageMinimum, int ageMaximum,
             TimeSpan duration, IEnumerable<string> bodyParts)
        {
            var exercise = new Exercise
            {
                Name = name, Description = description, AgeMinimum = ageMinimum, AgeMaximum = ageMaximum, 
                Duration = duration, 
            };
            _exerciseRepository.Add(exercise);
            AddBodyPartsToExercise(exercise, bodyParts);
            _exerciseRepository.SaveChanges();
        }

        internal void CreateMedicinePrescriptionItem(string name, string description, double price , IEnumerable<string> allergies, IEnumerable<string> diseases)
        {
            var medicine = new Medicine
            {
                Name = name,
                Description = description,
                Price = price
            };

            _medicineRepository.Add(medicine);
            AddMedicalConditionsToMedicine(medicine, allergies, diseases);
            _medicineRepository.SaveChanges();
        }

        internal void CreateTreatmentPrescriptionItem(string name, string description, int ageMinimum, int ageMaximum,
             TimeSpan duration, string bodyPart)
        {

            var treatment = new Treatment
            {
                Name = name,
                Description = description,
                AgeMinimum = ageMinimum,
                AgeMaximum = ageMaximum,
                Duration = duration,
                BodyPart = (BodyPart)Enum.Parse(typeof(BodyPart), bodyPart)
            };
            _treatmentRepository.Add(treatment);
            _treatmentRepository.SaveChanges();
        }

        private void AddMedicalConditionsToMedicine(Medicine medicine, IEnumerable<string> allergies, IEnumerable<string> diseases)
        {
            foreach (var allergyString in allergies)
            {
                _medicineRepository.AddMedicalConditionToMedicine(medicine, MedicalConditionService.Instance.GetMedicalConditionByName(allergyString));
            }

            foreach (var diseaseString in diseases)
            {
                _medicineRepository.AddMedicalConditionToMedicine(medicine, MedicalConditionService.Instance.GetMedicalConditionByName(diseaseString));
            }
        }

        private void AddBodyPartsToExercise(Exercise exercise, IEnumerable<string> bodyParts)
        {
            foreach (var bodyPartString in bodyParts)
            {
                _exerciseRepository.AddBodyPartsToExercise(exercise, (BodyPart)Enum.Parse(typeof(BodyPart), bodyPartString));
            }
        }

        internal IEnumerable<Treatment> GetAllTreatments()
        {
            return _treatmentRepository.GetAll();
        }

        internal Treatment GetTreatmentByNameBodyPartAndDuration(string name, BodyPart bodyPart,TimeSpan duration)
        {
            return _treatmentRepository.Find(e => e.Name == name && e.BodyPart == bodyPart && e.Duration == duration).First();
        }
    }
}