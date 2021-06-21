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


        public new void SaveChanges()
        {
            base.SaveChanges();
            _medicineHasIncompatibilityRepository.SaveChanges();
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


        public IEnumerable<MedicineHasIncompatibleMedicalConditions> GetIncompatibleMedicalConditionsOfMedicineByMedicineId(int id)
        {
            return _medicineHasIncompatibilityRepository.Find(e => e.MedicineId == id);
        }

        public IEnumerable<int> GetMedicineIncompatibleMedicalConditionsIds(IEnumerable<MedicineHasIncompatibleMedicalConditions> medicineIncompatibleMedicalConditions)
        {
            var ids = new List<int>();

            foreach (var medicalCondition in medicineIncompatibleMedicalConditions)
            {
                ids.Add(medicalCondition.MedicalConditionId);
            }

            return ids;
        }

    }
}