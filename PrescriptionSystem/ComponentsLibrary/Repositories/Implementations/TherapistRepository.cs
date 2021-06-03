using ComponentsLibrary.Repositories.Interfaces;

namespace ComponentsLibrary.Repositories.Implementations
{
    public class TherapistRepository:UserRepository, ITherapistRepository
    {
        public TherapistRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}