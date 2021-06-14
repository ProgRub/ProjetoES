using System.Collections;
using System.Collections.Generic;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;

namespace ComponentsLibrary.Repositories.Interfaces
{
    public interface ITherapySessionRepository:IGenericRepository<TherapySession>
    {
        void AddTreatmentToTherapySession(TherapySession therapySession, Treatment treatment);
        IEnumerable<TherapySessionHasTreatments> GetTherapySessionHasTreatmentsEnumerableBySessionId(int id);

        TherapySessionHasTreatments GetTherapySessionHasTreatmentsBySessionIdTreatmentId(int sessionId,
            int treatmentId);
    }
}