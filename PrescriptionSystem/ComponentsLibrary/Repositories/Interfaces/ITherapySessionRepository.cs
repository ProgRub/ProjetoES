using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;

namespace ComponentsLibrary.Repositories.Interfaces
{
    public interface ITherapySessionRepository:IGenericRepository<TherapySession>
    {
        void AddTreatmentToTherapySession(TherapySession therapySession, Treatment treatment);
    }
}