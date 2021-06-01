using ComponentsLibrary.Entities;

namespace ComponentsLibrary.Repositories
{
    public class PatientRepository:UserRepository
    {
        public PatientRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}