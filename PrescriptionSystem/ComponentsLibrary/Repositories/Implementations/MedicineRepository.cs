using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using ComponentsLibrary.Repositories.Interfaces;
using System.Collections.Generic;

namespace ComponentsLibrary.Repositories.Implementations
{
    public class MedicineRepository:BaseRepository<Medicine>, IMedicineRepository
    {
        private MedicineHasIncompatibilityRepository _medicineHasIncompatibilityRepository;
        public MedicineRepository(PrescriptionSystemDbContext context) : base(context)
        {
            _medicineHasIncompatibilityRepository = new MedicineHasIncompatibilityRepository(context);
        }

        public void AddMedicalConditionToMedicine(Medicine medicine, MedicalCondition medicalCondition)
        {
            if(medicine.MedicineHasIncompatibleMedicalConditionsList == null)
            {
                medicine.MedicineHasIncompatibleMedicalConditionsList = new List<MedicineHasIncompatibleMedicalConditions>{
                    new MedicineHasIncompatibleMedicalConditions
                    {
                        Medicine = medicine, MedicalCondition = medicalCondition
                    }
                };
            }
            else
            {
                medicine.MedicineHasIncompatibleMedicalConditionsList.Add(new MedicineHasIncompatibleMedicalConditions
                {
                    Medicine = medicine,
                    MedicalCondition = medicalCondition
                });
            }
            
        }

        public IEnumerable<int> GetMedicineIncompatibleMedicalConditionsIds(int medicineId)
        {
            var medicineIncompatibleMedicalConditions = _medicineHasIncompatibilityRepository.Find(e => e.MedicineId == medicineId);

            var medicalConditionsIds = new List<int>();

            foreach (var medicalCondition in medicineIncompatibleMedicalConditions)
            {
                medicalConditionsIds.Add(medicalCondition.MedicalConditionId);
            }

            return medicalConditionsIds;
        }

    }
}