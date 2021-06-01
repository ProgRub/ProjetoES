using ComponentsLibrary.Entities;

namespace ComponentsLibrary.Repositories
{
    public class TherapySessionRepository:BaseRepository<TherapySession>
    {
        private TherapySessionHasTreatmentsRepository _therapySessionHasTreatmentsRepository;
        public TherapySessionRepository(PrescriptionSystemDbContext context) : base(context)
        {
            _therapySessionHasTreatmentsRepository = new TherapySessionHasTreatmentsRepository(context);
        }
    }
}