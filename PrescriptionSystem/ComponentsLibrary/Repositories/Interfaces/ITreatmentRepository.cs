using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;

namespace ComponentsLibrary.Repositories.Interfaces
{
    public interface ITreatmentRepository:IGenericRepository<Treatment>
    {
        void AddBodyPartsToTreatment(Treatment treatment, BodyPart bodyPart);
    }
}