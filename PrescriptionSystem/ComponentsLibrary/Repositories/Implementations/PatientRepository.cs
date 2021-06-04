using ComponentsLibrary.Entities;
using ComponentsLibrary.Repositories.Interfaces;

namespace ComponentsLibrary.Repositories.Implementations
{
    internal class PatientRepository:BaseRepository<Patient>,IPatientRepository
    {
        public PatientRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}