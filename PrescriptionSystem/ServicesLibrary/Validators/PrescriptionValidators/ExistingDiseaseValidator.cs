using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using System;
using System.Collections.Generic;

namespace ServicesLibrary.Validators.PrescriptionValidators
{
    public class ExistingDiseaseValidator : BaseValidator
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
                        foreach (var incompatibleMedicalConditions in medicine.MedicineHasIncompatibleMedicalConditionsList)
                        {
                            if (incompatibleMedicalConditions.MedicalCondition.Type == Disease)
                            {
                                foreach (var patientMedicalCondition in prescription.Patient.UserHasMedicalConditions)
                                {
                                    if (patientMedicalCondition.MedicalCondition == incompatibleMedicalConditions.MedicalCondition) errorCodes.Add(Services.IncompatibleDisease);
                                }
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