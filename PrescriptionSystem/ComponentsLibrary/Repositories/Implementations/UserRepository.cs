using ComponentsLibrary.Entities;
using ComponentsLibrary.Repositories.Interfaces;

namespace ComponentsLibrary.Repositories.Implementations
{
    public abstract class UserRepository:BaseRepository<User>, IUserRepository
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