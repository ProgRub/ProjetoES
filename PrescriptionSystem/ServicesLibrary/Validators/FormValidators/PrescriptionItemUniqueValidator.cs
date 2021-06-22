using System;
using System.Collections.Generic;
using System.Linq;
using ServicesLibrary.DifferentServices;
using ServicesLibrary.DTOs;

namespace ServicesLibrary.Validators.FormValidators
{
    public class PrescriptionItemUniqueValidator : BaseValidator
    {
        public PrescriptionItemUniqueValidator(int errorCode, ref List<int> errorCodes) : base(errorCode,
            ref errorCodes)
        {
        }

        public override bool RequestIsValid(object request)
        {
            switch (request)
            {
                case MedicineDTO medicine:
                {
                    return PrescriptionItemService.Instance.GetAllMedicine().All(medicineInDB =>
                        medicineInDB.Name != medicine.Name || medicineInDB.Price != medicine.Price);
                }
                case ExerciseDTO exercise:
                {
                    return PrescriptionItemService.Instance.GetAllExercises().All(exerciseInDB =>
                        exerciseInDB.Name != exercise.Name ||
                        !exerciseInDB.BodyParts.All(e => exercise.BodyParts.Contains(e)) ||
                        exerciseInDB.Duration != exercise.Duration);
                }
                case TreatmentDTO treatment:
                {
                    return PrescriptionItemService.Instance.GetAllTreatments().All(treatmentInDB =>
                        treatmentInDB.Name != treatment.Name || treatmentInDB.BodyPart != treatment.BodyPart ||
                        treatmentInDB.Duration != treatment.Duration);
                }
                default:
                    throw new NotSupportedException($"Invalid type {request.GetType()}!");
            }
        }
    }
}