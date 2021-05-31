using ComponentsLibrary.Entities;

namespace ComponentsLibrary
{
    public class TherapySessionRepository:BaseRepository<TherapySession>
    {
        public TherapySessionRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}