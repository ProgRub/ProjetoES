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

            medicine.MedicineHasIncompatibleMedicalConditionsList = new List<MedicineHasIncompatibleMedicalConditions>
            {
                new MedicineHasIncompatibleMedicalConditions
                {
                    Medicine = medicine, MedicalCondition = medicalCondition
                }
            };
        }
        
    }
}