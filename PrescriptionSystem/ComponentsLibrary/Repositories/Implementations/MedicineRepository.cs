using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using ComponentsLibrary.Repositories.Interfaces;
using System.Collections.Generic;

namespace ComponentsLibrary.Repositories.Implementations
{
    public class MedicineRepository : BaseRepository<Medicine>, IMedicineRepository
    {
        private readonly MedicineHasIncompatibilityRepository _medicineHasIncompatibilityRepository;

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
            if (medicine.MedicineHasIncompatibleMedicalConditionsList == null)
            {
                medicine.MedicineHasIncompatibleMedicalConditionsList =
                    new List<MedicineHasIncompatibleMedicalConditions>
                    {
                        new MedicineHasIncompatibleMedicalConditions
                        {
                            MedicineId = medicine.Id, MedicalConditionId = medicalCondition.Id
                        }
                    };
            }
            else
            {
                medicine.MedicineHasIncompatibleMedicalConditionsList.Add(new MedicineHasIncompatibleMedicalConditions
                {
                    MedicineId = medicine.Id,
                    MedicalConditionId = medicalCondition.Id
                });
            }
        }


        public IEnumerable<MedicineHasIncompatibleMedicalConditions>
            GetIncompatibleMedicalConditionsOfMedicineByMedicineId(int id)
        {
            return _medicineHasIncompatibilityRepository.Find(e => e.MedicineId == id);
        }
    }
}