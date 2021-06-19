using System.Collections.Generic;
using ComponentsLibrary.Entities.PrescriptionItems;
using ServicesLibrary.DifferentServices;
using System;
using System.Diagnostics;
using System.Linq;
using ServicesLibrary.DTOs;

namespace ServicesLibrary.Validators.PrescriptionValidators
{
    public class AllergyValidator : BaseValidator
    {

        public AllergyValidator(int errorCode, ref List<int> errorCodes) : base(errorCode, ref errorCodes)
        {
        }
        public bool MedicalConditionIsAllergy(int id)
        {
            return MedicalConditionService.Instance.GetAllergies().Any(e => e.Id == id);
        }

        public override bool RequestIsValid(object request)
        {
            if (request is PrescriptionDTO prescription)
            {
                foreach (var medicine in prescription.Medicines)
                {
                    foreach (var allergenic in medicine.IncompatibleAllergies)
                    {
                        foreach (var allergy in prescription.Patient.Allergies)
                        {
                            if (allergy.Id == allergenic.Id) return false;
                        }
                    }
                        //var medicineIncompatibleMedicalConditionsIds =
                        //    PrescriptionItemService.Instance.GetMedicineIncompatibleMedicalConditionsIds(
                        //        PrescriptionItemService.Instance.GetMedicineIncompatibleMedicalConditions(medicine.Id));
                        //var userMedicalConditions = UserService.Instance.GetUsersMedicalConditionsByUserId(prescription.PatientId);

                        //foreach (var incompatibleMedicalConditionId in medicineIncompatibleMedicalConditionsIds)
                        //{
                        //    foreach (var patientMedicalCondition in userMedicalConditions)
                        //    {
                        //        if (patientMedicalCondition.Id== incompatibleMedicalConditionId &&
                        //            MedicalConditionIsAllergy(patientMedicalCondition.Id))
                        //            return false;
                        //    }
                        //}
                }

                return true;
            }

            throw new NotSupportedException($"Invalid type {request.GetType()}!");
        }

    }
}