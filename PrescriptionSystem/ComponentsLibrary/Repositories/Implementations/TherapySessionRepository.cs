using ComponentsLibrary.Entities;
using ComponentsLibrary.Repositories.Interfaces;

namespace ComponentsLibrary.Repositories.Implementations
{
    public class TherapySessionRepository:BaseRepository<TherapySession>, ITherapySessionRepository
    {
        private TherapySessionHasTreatmentsRepository _therapySessionHasTreatmentsRepository;
        public TherapySessionRepository(PrescriptionSystemDbContext context) : base(context)
        {
            _therapySessionHasTreatmentsRepository = new TherapySessionHasTreatmentsRepository(context);
        }
    }
}