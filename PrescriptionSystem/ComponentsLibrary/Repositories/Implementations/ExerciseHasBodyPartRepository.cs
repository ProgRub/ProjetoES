using ComponentsLibrary.Entities.PrescriptionItems;

namespace ComponentsLibrary.Repositories.Implementations
{
    internal class ExerciseHasBodyPartRepository : BaseRepository<ExerciseHasBodyParts>
    {
        internal ExerciseHasBodyPartRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}