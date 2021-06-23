using ComponentsLibrary.Entities;

namespace ComponentsLibrary.Repositories.Implementations
{
    internal class UserHasMedicalConditionRepository : BaseRepository<UserHasMedicalCondition>
    {
        public UserHasMedicalConditionRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}