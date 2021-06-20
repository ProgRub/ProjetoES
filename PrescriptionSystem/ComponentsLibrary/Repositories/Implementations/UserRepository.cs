using System.Collections.Generic;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Repositories.Interfaces;

namespace ComponentsLibrary.Repositories.Implementations
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private UserHasMissingBodyPartRepository _userHasMissingBodyPartRepository;

        private UserHasMedicalConditionRepository _userHasMedicalConditionRepository;

        public UserRepository(PrescriptionSystemDbContext context) : base(context)
        {
            _userHasMissingBodyPartRepository = new UserHasMissingBodyPartRepository(context);
            _userHasMedicalConditionRepository = new UserHasMedicalConditionRepository(context);
        }

        public void AddMedicalConditionToUser(User user, MedicalCondition medicalCondition)
        {
            if (user.UserHasMedicalConditions == null)
            {
                user.UserHasMedicalConditions = new List<UserHasMedicalCondition>
                {
                    new UserHasMedicalCondition
                    {
                        User = user, MedicalCondition = medicalCondition
                    }
                };
            }
            else
            {
                user.UserHasMedicalConditions.Add(new UserHasMedicalCondition
                {
                    User = user,
                    MedicalCondition = medicalCondition
                });
            }
        }

        public void AddMissingBodyPartToUser(User user, BodyPart bodyPart)
        {
            _userHasMissingBodyPartRepository.Add(new UserHasMissingBodyPart
            {
                User = user, BodyPart = bodyPart
            });
        }

        public IEnumerable<UserHasMissingBodyPart> GetUserHasMissingBodyPartEnumerableByUserId(int id)
        {
            return _userHasMissingBodyPartRepository.Find(e => e.User.Id == id);
        }

        public IEnumerable<UserHasMedicalCondition> GetUserHasMedicalConditionsEnumerableByUserId(int userId)
        {
            return _userHasMedicalConditionRepository.Find(e => e.UserId == userId);
        }
    }
}