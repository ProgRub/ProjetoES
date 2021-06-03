using ComponentsLibrary.Entities;
using ComponentsLibrary.Repositories.Interfaces;

namespace ComponentsLibrary.Repositories.Implementations
{
    public class MedicalConditionRepository:BaseRepository<MedicalCondition>, IMedicalConditionRepository
    {
        public MedicalConditionRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}