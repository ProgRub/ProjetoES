using ComponentsLibrary.Entities;

namespace ComponentsLibrary.Repositories
{
    public class TherapistRepository:UserRepository
    {
        public TherapistRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}