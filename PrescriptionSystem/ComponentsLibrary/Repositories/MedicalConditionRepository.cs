using ComponentsLibrary.Entities;

namespace ComponentsLibrary.Repositories
{
    public class MedicalConditionRepository:BaseRepository<MedicalCondition>
    {
        public MedicalConditionRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}