using ComponentsLibrary.Entities;

namespace ComponentsLibrary.Repositories
{
    internal class TherapySessionHasTreatmentsRepository:BaseRepository<TherapySessionHasTreatments>
    {
        public TherapySessionHasTreatmentsRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}