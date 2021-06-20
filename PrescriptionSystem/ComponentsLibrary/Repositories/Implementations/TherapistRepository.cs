
using ComponentsLibrary.Entities;
using ComponentsLibrary.Repositories.Interfaces;

namespace ComponentsLibrary.Repositories.Implementations
{
    public class TherapistRepository:BaseRepository<Therapist>,ITherapistRepository
    {
        public TherapistRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}