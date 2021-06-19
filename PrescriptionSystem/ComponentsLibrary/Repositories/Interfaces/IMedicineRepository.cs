using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using System.Collections.Generic;

namespace ComponentsLibrary.Repositories.Interfaces
{
    public interface IMedicineRepository:IGenericRepository<Medicine>
    {

        void AddMedicalConditionToMedicine(Medicine medicine, MedicalCondition medicalCondition);
        IEnumerable<MedicineHasIncompatibleMedicalConditions> GetIncompatibleMedicalConditions(int id);
        IEnumerable<int> GetMedicineIncompatibleMedicalConditionsIds(IEnumerable<MedicineHasIncompatibleMedicalConditions> medicineIncompatibleMedicalConditions);
    }
}