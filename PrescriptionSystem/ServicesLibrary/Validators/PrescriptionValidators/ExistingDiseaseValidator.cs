using System.Collections.Generic;

namespace ServicesLibrary.Validators.Prescription
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using ServicesLibrary.DifferentServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ServicesLibrary.Validators.PrescriptionValidators
{
    public class ExistingDiseaseValidator : BaseValidator
    {

        public ExistingDiseaseValidator(int errorCode, ref List<int> errorCodes) : base(errorCode, ref errorCodes)
        {
        public const int Disease = 1;
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
                    if (item is Medicine medicine)
                    {
                        var medicineIncompatibleMedicalConditionsIds = PrescriptionItemService.Instance.GetMedicineIncompatibleMedicalConditionsIds(PrescriptionItemService.Instance.GetMedicineIncompatibleMedicalConditions(medicine.Id));
                        var userMedicalConditions = UserService.Instance.GetMedicalConditions();

                        foreach (var incompatibleMedicalConditionId in medicineIncompatibleMedicalConditionsIds)
                        {
                            foreach (var patientMedicalCondition in userMedicalConditions)
                            {
                                if (patientMedicalCondition.MedicalConditionId == incompatibleMedicalConditionId && MedicalConditionIsDisease(patientMedicalCondition.MedicalConditionId)) errorCodes.Add(Services.IncompatibleMedicine);
                            }
                        }
                    }
                }

                requestList = new List<object> { request, prescriptionItems, errorCodes };
                return base.Validate(requestList) ?? errorCodes;
            }

            throw new NotSupportedException($"Invalid type {request.GetType()}!");
        }

        public override bool RequestIsValid(object request)
        {
            throw new System.NotImplementedException();
        }
        private bool MedicalConditionIsDisease(int id)
        {
            var diseases = MedicalConditionService.Instance.GetDiseases();

            foreach (var disease in diseases)
            {
                if (disease.Id == id) return true;
            }
            return false;
        }
    }
}