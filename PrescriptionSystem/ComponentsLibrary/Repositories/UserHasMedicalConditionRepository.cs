using ComponentsLibrary.Entities;

namespace ComponentsLibrary.Repositories
{
    internal class UserHasMedicalConditionRepository:BaseRepository<UserHasMedicalCondition>
    {
        public UserHasMedicalConditionRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}