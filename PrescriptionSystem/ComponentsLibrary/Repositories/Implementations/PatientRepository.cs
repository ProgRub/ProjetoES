using ComponentsLibrary.Repositories.Interfaces;

namespace ComponentsLibrary.Repositories.Implementations
{
    public class PatientRepository:UserRepository, IPatientRepository
    {
        public PatientRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}