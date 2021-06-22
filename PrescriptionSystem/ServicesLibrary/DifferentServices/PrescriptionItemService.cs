using ComponentsLibrary;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using ComponentsLibrary.Repositories.Implementations;
using ComponentsLibrary.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using ServicesLibrary.DTOs;

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

        public void CreateExercisePrescriptionItem(ExerciseDTO exerciseDTO)
        {
            var exercise = new Exercise
            {
                Name = exerciseDTO.Name,
                Description = exerciseDTO.Description,
                AgeMinimum = exerciseDTO.AgeMinimum,
                AgeMaximum = exerciseDTO.AgeMaximum,
                Duration = exerciseDTO.Duration,
                BodyParts = exerciseDTO.BodyParts.ToList()
            };
            _exerciseRepository.Add(exercise);
            _exerciseRepository.SaveChanges();
        }

        public void CreateMedicinePrescriptionItem(MedicineDTO medicineDTO)
        {
            var medicine = new Medicine
            {
                Name = medicineDTO.Name,
                Description = medicineDTO.Description,
                Price = medicineDTO.Price
            };

            _medicineRepository.Add(medicine);
            AddIncompatibleMedicalConditionsToMedicine(medicine, medicineDTO.IncompatibleAllergies,
                medicineDTO.IncompatibleDiseases);
            _medicineRepository.SaveChanges();
        }

        private void AddIncompatibleMedicalConditionsToMedicine(Medicine medicine,
            IEnumerable<MedicalConditionDTO> allergies, IEnumerable<MedicalConditionDTO> diseases)
        {
            foreach (var allergy in allergies)
            {
                _medicineRepository.AddMedicalConditionToMedicine(medicine,
                    MedicalConditionService.Instance.GetMedicalConditionById(allergy.Id));
            }

            foreach (var disease in diseases)
            {
                _medicineRepository.AddMedicalConditionToMedicine(medicine,
                    MedicalConditionService.Instance.GetMedicalConditionById(disease.Id));
            }
        }

        internal void CreateTreatmentPrescriptionItem(TreatmentDTO treatmentDTO)
        {
            var treatment = new Treatment
            {
                Name = treatmentDTO.Name,
                Description = treatmentDTO.Description,
                AgeMinimum = treatmentDTO.AgeMinimum,
                AgeMaximum = treatmentDTO.AgeMaximum,
                Duration = treatmentDTO.Duration,
                BodyPart = treatmentDTO.BodyPart
            };
            _treatmentRepository.Add(treatment);
            _treatmentRepository.SaveChanges();
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

        internal Treatment GetTreatmentById(int id)
        {
            return _treatmentRepository.GetById(id);
        }

        internal IEnumerable<MedicineHasIncompatibleMedicalConditions>
            GetMedicineIncompatibleMedicalConditionsEnumerableByMedicineId(int id)
        {
            return _medicineRepository.GetIncompatibleMedicalConditionsOfMedicineByMedicineId(id);
        }

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

        public PrescriptionItem GetPrescriptionItemById(int prescriptionItemId)
        {
            if (IsExercise(prescriptionItemId)) return GetExerciseById(prescriptionItemId);
            if (IsMedicine(prescriptionItemId)) return GetMedicineById(prescriptionItemId);
            return GetTreatmentById(prescriptionItemId);
        }
    }
}