using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;

namespace ComponentsLibrary.Repositories.Interfaces
{
    public interface IExerciseRepository:IGenericRepository<Exercise>
    {
        void AddBodyPartsToExercise(Exercise exercise, BodyPart bodyPart);
    }
}