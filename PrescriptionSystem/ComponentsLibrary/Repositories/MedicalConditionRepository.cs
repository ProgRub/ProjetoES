using ComponentsLibrary.Entities;

namespace ComponentsLibrary
{
    public class MedicalConditionRepository:BaseRepository<MedicalCondition>
    {
        public MedicalConditionRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}