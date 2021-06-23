using System.Collections.Generic;
using ComponentsLibrary.Entities;

namespace ComponentsLibrary.Repositories.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        void AddMedicalConditionToUser(User user, MedicalCondition medicalCondition);
        IEnumerable<UserHasMedicalCondition> GetUserHasMedicalConditionsEnumerableByUserId(int userId);
    }
}