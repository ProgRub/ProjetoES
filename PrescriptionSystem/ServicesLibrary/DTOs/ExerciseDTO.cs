using System;
using System.Collections;
using System.Collections.Generic;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using ServicesLibrary.DifferentServices;

namespace ServicesLibrary.DTOs
{
    public class ExerciseDTO:PrescriptionItemDTO
    {
        public TimeSpan Duration { get; set; }
        public int AgeMinimum { get; set; }
        public int AgeMaximum { get; set; }
        public IEnumerable<BodyPart> BodyParts { get; set; }

        internal static ExerciseDTO ConvertExerciseToDTO(Exercise exercise)
        {
            var exerciseDTO = new ExerciseDTO
            {
                Id = exercise.Id,
                AgeMaximum = exercise.AgeMaximum, AgeMinimum = exercise.AgeMinimum, Description = exercise.Description,
                Duration = exercise.Duration, Name = exercise.Name
            };
            exerciseDTO.BodyParts = PrescriptionItemService.Instance.GetExerciseBodyPartsByExerciseId(exerciseDTO.Id);
            return exerciseDTO;
        }
    }
}