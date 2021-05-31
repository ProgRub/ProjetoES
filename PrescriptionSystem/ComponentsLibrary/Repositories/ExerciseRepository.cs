using ComponentsLibrary.Entities.PrescriptionItems;

namespace ComponentsLibrary
{
    public class ExerciseRepository:BaseRepository<Exercise>
    {
        public ExerciseRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}