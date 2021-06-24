using System.Collections.Generic;
using System.Linq;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using ComponentsLibrary.Repositories.Interfaces;

namespace ComponentsLibrary.Repositories.Implementations
{
    public class TherapySessionRepository : BaseRepository<TherapySession>, ITherapySessionRepository
    {
        private readonly TherapySessionHasTreatmentsRepository _therapySessionHasTreatmentsRepository;

        public TherapySessionRepository(PrescriptionSystemDbContext context) : base(context)
        {
            _therapySessionHasTreatmentsRepository = new TherapySessionHasTreatmentsRepository(context);
        }

        public new void SaveChanges()
        {
            base.SaveChanges();
            _therapySessionHasTreatmentsRepository.SaveChanges();
        }

        public void AddTreatmentToTherapySession(TherapySession therapySession, Treatment treatment)
        {
            if (therapySession.TherapySessionHasTreatmentsCollection == null)
            {
                therapySession.TherapySessionHasTreatmentsCollection = new List<TherapySessionHasTreatments>
                {
                    new TherapySessionHasTreatments
                    {
                        TherapySessionId = therapySession.Id, TreatmentId = treatment.Id
                    }
                };
            }
            else
            {
                therapySession.TherapySessionHasTreatmentsCollection.Add(new TherapySessionHasTreatments
                {
                    TherapySessionId = therapySession.Id,
                    TreatmentId = treatment.Id
                });
            }
        }

        public IEnumerable<TherapySessionHasTreatments> GetTherapySessionHasTreatmentsEnumerableBySessionId(int id)
        {
            return _therapySessionHasTreatmentsRepository.Find(e => e.TherapySessionId == id);
        }

        public TherapySessionHasTreatments GetTherapySessionHasTreatmentsBySessionIdTreatmentId(int sessionId,
            int treatmentId)
        {
            return _therapySessionHasTreatmentsRepository.Find(e =>
                e.TherapySessionId == sessionId && e.TreatmentId == treatmentId).First();
        }
    }
}