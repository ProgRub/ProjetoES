using ComponentsLibrary.Entities.PrescriptionItems;
using ComponentsLibrary.Repositories.Interfaces;

namespace ComponentsLibrary.Repositories.Implementations
{
    public class ExerciseRepository:BaseRepository<Exercise>, IExerciseRepository
    {
        public ExerciseRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }
    }
}