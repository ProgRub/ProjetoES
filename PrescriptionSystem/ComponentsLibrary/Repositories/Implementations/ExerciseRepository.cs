using ComponentsLibrary.Entities.PrescriptionItems;
using ComponentsLibrary.Repositories.Interfaces;

namespace ComponentsLibrary.Repositories.Implementations
{
    public class ExerciseRepository:BaseRepository<Exercise>, IExerciseRepository
    {
        private ExerciseHasBodyPartRepository _exerciseHasBodyPartRepository;
        public ExerciseRepository(PrescriptionSystemDbContext context) : base(context)
        {
            _exerciseHasBodyPartRepository = new ExerciseHasBodyPartRepository(context);
        }
    }
}