using ComponentsLibrary;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using ComponentsLibrary.Repositories.Implementations;
using ComponentsLibrary.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace ServicesLibrary.DifferentServices
{
    public class PrescriptionItemService
    {
        private IMedicineRepository _medicineRepository;
        private IExerciseRepository _exerciseRepository;
        private ITreatmentRepository _treatmentRepository;

        public PrescriptionItemService()
        {
            _medicineRepository = new MedicineRepository(Database.GetContext());
            _exerciseRepository = new ExerciseRepository(Database.GetContext());
            _treatmentRepository = new TreatmentRepository(Database.GetContext());
        }

        internal void CreateExercisePrescriptionItem(string name, string description, int ageMinimum, int ageMaximum,
             TimeSpan duration, IEnumerable<string> bodyParts)
        {
            Exercise exercise = new Exercise
            {
                Name = name, Description = description, AgeMinimum = ageMinimum, AgeMaximum = ageMaximum, 
                Duration = duration, 
            };
            _exerciseRepository.Add(exercise);
            AddBodyPartsToExercise(exercise, bodyParts);
        }

        internal void CreateMedicinePrescriptionItem(string name, string description, double price , IEnumerable<string> allergies, IEnumerable<string> diseases)
        {
            Medicine medicine = new Medicine
            {
                Name = name,
                Description = description,
                Price = price
            };

            _medicineRepository.Add(medicine);
            AddMedicalConditionsToMedicine(medicine, allergies, diseases);
        }

        internal void CreateTreatmentPrescriptionItem(string name, string description, int ageMinimum, int ageMaximum,
             TimeSpan duration, string bodyPart)
        {

            Treatment treatment = new Treatment
            {
                Name = name,
                Description = description,
                AgeMinimum = ageMinimum,
                AgeMaximum = ageMaximum,
                Duration = duration,
                BodyPart = (BodyPart)Enum.Parse(typeof(BodyPart), bodyPart)
            };
            _treatmentRepository.Add(treatment);
        }

        private void AddMedicalConditionsToMedicine(Medicine medicine, IEnumerable<string> allergies, IEnumerable<string> diseases)
        {
            foreach (var allergyString in allergies)
            {
                _medicineRepository.AddMedicalConditionToMedicine(medicine, Services.Instance.GetMedicalConditionByName(allergyString));
            }

            foreach (var diseaseString in diseases)
            {
                _medicineRepository.AddMedicalConditionToMedicine(medicine, Services.Instance.GetMedicalConditionByName(diseaseString));
            }
        }

        private void AddBodyPartsToExercise(Exercise exercise, IEnumerable<string> bodyParts)
        {
            foreach (var bodyPartString in bodyParts)
            {
                _exerciseRepository.AddBodyPartsToExercise(exercise, (BodyPart)Enum.Parse(typeof(BodyPart), bodyPartString));
            }
        }
    }
}