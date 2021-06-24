using System.Collections.Generic;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Repositories.Interfaces;

namespace ComponentsLibrary.Repositories.Implementations
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly UserHasMedicalConditionRepository _userHasMedicalConditionRepository;

        public UserRepository(PrescriptionSystemDbContext context) : base(context)
        {
            _userHasMedicalConditionRepository = new UserHasMedicalConditionRepository(context);
        }


        public new void SaveChanges()
        {
            base.SaveChanges();
            _userHasMedicalConditionRepository.SaveChanges();
        }

        public void AddMedicalConditionToUser(User user, MedicalCondition medicalCondition)
        {
            if (user.UserHasMedicalConditions == null)
            {
                user.UserHasMedicalConditions = new List<UserHasMedicalCondition>
                {
                    new UserHasMedicalCondition
                    {
                        UserId = user.Id, MedicalConditionId = medicalCondition.Id
                    }
                };
            }
            else
            {
                user.UserHasMedicalConditions.Add(new UserHasMedicalCondition
                {
                    UserId = user.Id,
                    MedicalConditionId = medicalCondition.Id
                });
            }
        }

        public IEnumerable<UserHasMedicalCondition> GetUserHasMedicalConditionsEnumerableByUserId(int userId)
        {
            return _userHasMedicalConditionRepository.Find(e => e.UserId == userId);
        }
    }
}