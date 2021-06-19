using System.Collections.Generic;
using System.Linq;
using ComponentsLibrary.Entities;
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

        public void AddBodyPartsToExercise(Exercise exercise, BodyPart bodyPart)
        {
            _exerciseHasBodyPartRepository.Add(new ExerciseHasBodyParts {Exercise = exercise, BodyPart = bodyPart});
        }

        public IEnumerable<BodyPart> GetExerciseBodyPartsByExerciseId(int exerciseId)
        {
            return _exerciseHasBodyPartRepository.Find(e => e.ExerciseId == exerciseId).Select(e => e.BodyPart);
        }
    }
}