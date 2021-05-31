using ComponentsLibrary.Entities;

namespace ComponentsLibrary
{
    public class TherapistRepository:BaseRepository<Therapist>
    {
        public TherapistRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}