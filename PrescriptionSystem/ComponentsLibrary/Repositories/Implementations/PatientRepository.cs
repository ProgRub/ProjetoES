using ComponentsLibrary.Entities;
using ComponentsLibrary.Repositories.Interfaces;

namespace ComponentsLibrary.Repositories.Implementations
{
    public class PatientRepository:BaseRepository<Patient>,IPatientRepository
    {
        public PatientRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}