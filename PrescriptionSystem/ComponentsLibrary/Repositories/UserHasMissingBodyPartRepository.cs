using ComponentsLibrary.Entities;

namespace ComponentsLibrary.Repositories
{
    internal class UserHasMissingBodyPartRepository:BaseRepository<UserHasMissingBodyPart>
    {
        public UserHasMissingBodyPartRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}