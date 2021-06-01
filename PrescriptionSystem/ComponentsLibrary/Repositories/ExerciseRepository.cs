using ComponentsLibrary.Entities.PrescriptionItems;

namespace ComponentsLibrary.Repositories
{
    public class ExerciseRepository:BaseRepository<Exercise>
    {
        public ExerciseRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}