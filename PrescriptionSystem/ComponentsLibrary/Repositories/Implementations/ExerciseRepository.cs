using System.Collections.Generic;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using ComponentsLibrary.Repositories.Interfaces;

namespace ComponentsLibrary.Repositories.Implementations
{
    public class ExerciseRepository : BaseRepository<Exercise>, IExerciseRepository
    {
        public ExerciseRepository(PrescriptionSystemDbContext context) : base(context)
        {
        }

        public void AddBodyPartsToExercise(Exercise exercise, BodyPart bodyPart)
        {
            if (exercise.BodyParts == null)
            {
                exercise.BodyParts = new List<BodyPart> {bodyPart};
            }
            else
            {
                exercise.BodyParts.Add(bodyPart);
            }
        }

        public IEnumerable<BodyPart> GetExerciseBodyPartsByExerciseId(int exerciseId)
        {
            return GetById(exerciseId).BodyParts;
        }
    }
}