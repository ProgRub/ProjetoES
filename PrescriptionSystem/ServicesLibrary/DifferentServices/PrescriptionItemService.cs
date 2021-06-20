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
        private readonly PrescriptionHasItemsRepository _prescriptionRepository;

        private PrescriptionItemService()
        {
            _medicineRepository = new MedicineRepository(Database.GetContext());
            _exerciseRepository = new ExerciseRepository(Database.GetContext());
            _treatmentRepository = new TreatmentRepository(Database.GetContext());
            _prescriptionRepository = new PrescriptionHasItemsRepository(Database.GetContext());
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

        internal void CreateMedicinePrescriptionItem(string name, string description, double price,
            IEnumerable<MedicalCondition> allergies, IEnumerable<MedicalCondition> diseases)
        {
            var medicine = new Medicine
            {
                Name = name,
                Description = description,
                Price = price
            };

            _medicineRepository.Add(medicine);
            AddIncompatibleMedicalConditionsToMedicine(medicine, allergies, diseases);
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
                BodyPart = (BodyPart) Enum.Parse(typeof(BodyPart), bodyPart)
            };
            _treatmentRepository.Add(treatment);
            _treatmentRepository.SaveChanges();
        }

        private void AddIncompatibleMedicalConditionsToMedicine(Medicine medicine, IEnumerable<MedicalCondition> allergies,
            IEnumerable<MedicalCondition> diseases)
        {
            foreach (var allergy in allergies)
            {
                _medicineRepository.AddMedicalConditionToMedicine(medicine,allergy);
            }

            foreach (var disease in diseases)
            {
                _medicineRepository.AddMedicalConditionToMedicine(medicine, disease);
            }
        }

        private void AddBodyPartsToExercise(Exercise exercise, IEnumerable<string> bodyParts)
        {
            foreach (var bodyPartString in bodyParts)
            {
                _exerciseRepository.AddBodyPartsToExercise(exercise,
                    (BodyPart) Enum.Parse(typeof(BodyPart), bodyPartString));
            }
        }


        internal IEnumerable<Treatment> GetAllTreatments()
        {
            return _treatmentRepository.GetAll();
        }

        internal IEnumerable<Medicine> GetAllMedicine()
        {
            return _medicineRepository.GetAll();
        }

        internal IEnumerable<Exercise> GetAllExercises()
        {
            return _exerciseRepository.GetAll();
        }

        internal Treatment GetTreatmentByName(string name)
        {
            return _treatmentRepository.Find(e => e.Name == name).First();
        }

        internal Medicine GetMedicineByName(string name)
        {
            return _medicineRepository.Find(e => e.Name == name).First();
        }

        internal Exercise GetExerciseByName(string name)
        {
            return _exerciseRepository.Find(e => e.Name == name).First();
        }

        internal Treatment GetTreatmentById(int id)
        {
            return _treatmentRepository.GetById(id);
        }

        internal IEnumerable<PrescriptionHasPrescriptionItems> GetPrescriptionHasItemsEnumerableByPrescriptionId(int prescriptionId)
        {
            return _prescriptionRepository.Find(e => e.PrescriptionId == prescriptionId);
        }

        internal IEnumerable<MedicineHasIncompatibleMedicalConditions> GetMedicineIncompatibleMedicalConditionsEnumerableByMedicineId(int id)
        {
            return _medicineRepository.GetIncompatibleMedicalConditionsOfMedicineByMedicineId(id);
        }

        //internal IEnumerable<int> GetMedicineIncompatibleMedicalConditionsIds(IEnumerable<MedicineHasIncompatibleMedicalConditions> medicineIncompatibleMedicalConditions)
        //{
        //    return _medicineRepository.GetMedicineIncompatibleMedicalConditionsIds(medicineIncompatibleMedicalConditions);
        //}

        internal Medicine GetMedicineById(int item_id)
        {
            return _medicineRepository.GetById(item_id);
        }

        internal Exercise GetExerciseById(int item_id)
        {
            return _exerciseRepository.GetById(item_id);
        }

        internal bool IsMedicine(int item_id)
        {
            return _medicineRepository.Find(e => e.Id == item_id).Any();
        }

        internal bool IsExercise(int item_id)
        {
            return _exerciseRepository.Find(e => e.Id == item_id).Any();
        }

        public IEnumerable<BodyPart> GetExerciseBodyPartsByExerciseId(int exerciseId)
        {
           return _exerciseRepository.GetExerciseBodyPartsByExerciseId(exerciseId);
        }
    }
}