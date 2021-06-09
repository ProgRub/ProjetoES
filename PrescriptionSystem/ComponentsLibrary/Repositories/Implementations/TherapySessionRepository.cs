using System.Collections.Generic;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using ComponentsLibrary.Repositories.Interfaces;

namespace ComponentsLibrary.Repositories.Implementations
{
    public class TherapySessionRepository : BaseRepository<TherapySession>, ITherapySessionRepository
    {
        private TherapySessionHasTreatmentsRepository _therapySessionHasTreatmentsRepository;

        public TherapySessionRepository(PrescriptionSystemDbContext context) : base(context)
        {
            _therapySessionHasTreatmentsRepository = new TherapySessionHasTreatmentsRepository(context);
        }

        public void AddTreatmentToTherapySession(TherapySession therapySession, Treatment treatment)
        {
            if (therapySession.TherapySessionHasTreatmentsCollection == null)
            {
                therapySession.TherapySessionHasTreatmentsCollection = new List<TherapySessionHasTreatments>
                {
                    new TherapySessionHasTreatments
                    {
                        TherapySession = therapySession, Treatment = treatment
                    }
                };
            }
            else
            {
                therapySession.TherapySessionHasTreatmentsCollection.Add(new TherapySessionHasTreatments
                {
                    TherapySession = therapySession, Treatment = treatment
                });
            }
        }
    }
}