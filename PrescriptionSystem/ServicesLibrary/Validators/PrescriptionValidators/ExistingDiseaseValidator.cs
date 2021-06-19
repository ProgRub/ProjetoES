using System.Collections.Generic;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using ServicesLibrary.DifferentServices;
using System;
using System.Diagnostics;
using System.Linq;
using ServicesLibrary.DTOs;

namespace ServicesLibrary.Validators.PrescriptionValidators
{
    public class ExistingDiseaseValidator : BaseValidator
    {

        public ExistingDiseaseValidator(int errorCode, ref List<int> errorCodes) : base(errorCode, ref errorCodes)
        {
        }

        public override bool RequestIsValid(object request)
        {

            if (request is PrescriptionDTO prescription)
            {
                foreach (var medicine in prescription.Medicines)
                {
                    foreach (var incompatibleMedicalCondition in medicine.IncompatibleMedicalConditions)
                    {
                        foreach (var disease in prescription.Patient.Diseases)
                        {
                            if (disease.Id == incompatibleMedicalCondition.Id) return false;
                        }
                    }
                }

                return true;
            }
            //if (request is ComponentsLibrary.Entities.Prescription prescription)
            //{
            //    foreach (var item in PrescriptionService.Instance.GetPrescriptionItemsOfPrescriptionById(prescription.Id))
            //    {
            //        if (item is Medicine medicine)
            //        {
            //            var medicineIncompatibleMedicalConditionsIds = PrescriptionItemService.Instance.GetMedicineIncompatibleMedicalConditionsIds(PrescriptionItemService.Instance.GetMedicineIncompatibleMedicalConditions(medicine.Id));
            //            var userMedicalConditions = UserService.Instance.GetUsersMedicalConditionsByUserId(prescription.PatientId);

            //            foreach (var incompatibleMedicalConditionId in medicineIncompatibleMedicalConditionsIds)
            //            {
            //                foreach (var patientMedicalCondition in userMedicalConditions)
            //                {
            //                    if (patientMedicalCondition.Id == incompatibleMedicalConditionId &&
            //                        MedicalConditionIsDisease(patientMedicalCondition.Id)) return false;
            //                }
            //            }
            //        }
            //    }

            //    return true;
            //}

            throw new NotSupportedException($"Invalid type {request.GetType()}!");
        }
        
        private bool MedicalConditionIsDisease(int id)
        {
            return MedicalConditionService.Instance.GetDiseases().Any(e => e.Id == id);
        }
    }
}