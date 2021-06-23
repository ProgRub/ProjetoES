using ComponentsLibrary.Entities;

namespace ComponentsLibrary.Repositories.Implementations
{
    internal class TherapySessionHasTreatmentsRepository : BaseRepository<TherapySessionHasTreatments>
    {
        public TherapySessionHasTreatmentsRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}