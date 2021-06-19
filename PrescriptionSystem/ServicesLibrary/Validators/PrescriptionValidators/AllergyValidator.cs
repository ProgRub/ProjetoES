using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using ServicesLibrary.DifferentServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ServicesLibrary.Validators.PrescriptionValidators
{
    public class AllergyValidator : BaseValidator
    {

        public const int Allergy = 0;
        public override object Validate(object requestListParameter)
        {
            var requestList = (List<object>)requestListParameter;
            var request = requestList[0];
            var prescriptionItems = (List<PrescriptionItem>)requestList[1];
            var errorCodes = (List<int>)requestList[2];

            if (request is Prescription prescription)
            {
                foreach (var item in prescriptionItems) 
                {
                    if(item is Medicine medicine)
                    {
                        var medicineIncompatibleMedicalConditionsIds = PrescriptionItemService.Instance.GetMedicineIncompatibleMedicalConditionsIds(medicine.Id);
                        var userMedicalConditions = UserService.Instance.GetMedicalConditions();

                        foreach (var incompatibleMedicalConditionId in medicineIncompatibleMedicalConditionsIds)
                        {
                            foreach(var patientMedicalCondition in userMedicalConditions)
                            {
                                if (patientMedicalCondition.MedicalConditionId == incompatibleMedicalConditionId && MedicalConditionIsAllergy(patientMedicalCondition.MedicalConditionId)) Services.Instance.AddErrorCode(errorCodes, Services.IncompatibleMedicine);
                            }
                        }
                    }
                }

                requestList = new List<object> { request, prescriptionItems, errorCodes };
                return base.Validate(requestList) ?? errorCodes;
            }

            throw new NotSupportedException($"Invalid type {request.GetType()}!");
        }

        public bool MedicalConditionIsAllergy(int id)
        {
            var allergies = MedicalConditionService.Instance.GetAllergies();

            foreach (var allergy in allergies)
            {
                if (allergy.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

    }
}