using System.Collections.Generic;

namespace ServicesLibrary.Validators.Prescription
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

        public AllergyValidator(int errorCode, ref List<int> errorCodes) : base(errorCode, ref errorCodes)
        {

        public const int Allergy = 0;

        public bool MedicalConditionIsAllergy(int id)
        {
            var allergies = MedicalConditionService.Instance.GetAllergies();

            foreach (var allergy in allergies)
            {
                if (allergy.Id == id) return true;
            }
            return false;
        }

        public override bool RequestIsValid(object request)
        {
            if (request is Prescription prescription)
            {
                foreach (var item in prescriptionItems)
                {
                    if (item is Medicine medicine)
                    {
                        var medicineIncompatibleMedicalConditionsIds = PrescriptionItemService.Instance.GetMedicineIncompatibleMedicalConditionsIds(PrescriptionItemService.Instance.GetMedicineIncompatibleMedicalConditions(medicine.Id));
                        var userMedicalConditions = UserService.Instance.GetMedicalConditions();

                        foreach (var incompatibleMedicalConditionId in medicineIncompatibleMedicalConditionsIds)
                        {
                            foreach (var patientMedicalCondition in userMedicalConditions)
                            {
                                if (patientMedicalCondition.MedicalConditionId == incompatibleMedicalConditionId && MedicalConditionIsAllergy(patientMedicalCondition.MedicalConditionId)) errorCodes.Add(Services.IncompatibleMedicine);
                            }
                        }
                    }
                }

                requestList = new List<object> { request, prescriptionItems, errorCodes };
                return base.Validate(requestList) ?? errorCodes;
            }

            throw new NotSupportedException($"Invalid type {request.GetType()}!");
        }
    }
}