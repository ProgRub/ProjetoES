using ComponentsLibrary.Entities;

namespace ComponentsLibrary.Repositories
{
    public abstract class UserRepository:BaseRepository<User>
    {
        private UserHasMedicalConditionRepository _userHasMedicalConditionRepository;
        private UserHasMissingBodyPartRepository _userHasMissingBodyPartRepository;
        protected UserRepository(PrescriptionSystemDbContext context) : base(context)
        {
            _userHasMedicalConditionRepository = new UserHasMedicalConditionRepository(context);
            _userHasMissingBodyPartRepository = new UserHasMissingBodyPartRepository(context);
        }
    }
}