using ComponentsLibrary.Entities;

namespace ComponentsLibrary.Repositories.Implementations
{
    internal class UserHasMissingBodyPartRepository:BaseRepository<UserHasMissingBodyPart>
    {
        public UserHasMissingBodyPartRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}