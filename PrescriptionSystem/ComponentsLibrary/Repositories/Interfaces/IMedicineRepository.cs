using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;

namespace ComponentsLibrary.Repositories.Interfaces
{
    public interface IMedicineRepository:IGenericRepository<Medicine>
    {

        void AddMedicalConditionToMedicine(Medicine medicine, MedicalCondition medicalCondition);
    }
}