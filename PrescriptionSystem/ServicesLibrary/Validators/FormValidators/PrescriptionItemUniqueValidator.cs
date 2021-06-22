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
                    foreach (var medicineInDB in PrescriptionItemService.Instance.GetAllMedicine())
                    {
                        if (medicineInDB.Name == medicine.Name && medicineInDB.Price == medicine.Price) return false;
                    }
                    return true;
                }
                case ExerciseDTO exercise:
                {
                    foreach (var exerciseInDB in PrescriptionItemService.Instance.GetAllExercises())
                    {
                        if (exerciseInDB.Name == exercise.Name &&
                            exerciseInDB.BodyParts.All(e=>exercise.BodyParts.Contains(e)) &&
                            exerciseInDB.Duration == exercise.Duration) return false;
                    }
                    return true;
                }
                case TreatmentDTO treatment:
                {
                    foreach (var treatmentInDB in PrescriptionItemService.Instance.GetAllTreatments())
                    {
                        if (treatmentInDB.Name == treatment.Name &&
                            treatmentInDB.BodyPart == treatment.BodyPart &&
                            treatmentInDB.Duration == treatment.Duration) return false;
                    }
                    return true;
                }
                default:
                    throw new NotSupportedException($"Invalid type {request.GetType()}!");
            }
        }
    }
}