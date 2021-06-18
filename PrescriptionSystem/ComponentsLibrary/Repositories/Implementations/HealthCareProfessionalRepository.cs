using ComponentsLibrary.Entities;
using ComponentsLibrary.Repositories.Interfaces;

namespace ComponentsLibrary.Repositories.Implementations
{
    public class HealthCareProfessionalRepository:BaseRepository<HealthCareProfessional>,IHealthCareProfessionalRepository
    {
        public HealthCareProfessionalRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}