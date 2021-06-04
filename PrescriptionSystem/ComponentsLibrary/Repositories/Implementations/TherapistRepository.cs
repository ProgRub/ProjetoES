
using ComponentsLibrary.Entities;
using ComponentsLibrary.Repositories.Interfaces;

namespace ComponentsLibrary.Repositories.Implementations
{
    internal class TherapistRepository:BaseRepository<Therapist>,ITherapistRepository
    {
        public TherapistRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}