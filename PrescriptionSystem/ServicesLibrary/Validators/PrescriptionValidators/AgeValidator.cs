using System;
using System.Collections.Generic;
using System.Diagnostics;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using ServicesLibrary.DifferentServices;

namespace ServicesLibrary.Validators.PrescriptionValidators
{
    public class AgeValidator:BaseValidator
    {
        public override object Validate(object requestListParameter)
        {
            var requestList = (List<object>)requestListParameter;
            var request = requestList[0];
            var prescriptionItems = (List<PrescriptionItem>) requestList[1];
            var errorCodes = (List<int>)requestList[2];

            if (request is  Prescription prescription)
            {
                var today = DateTime.Today;
                var patientsAge = today.Year - prescription.Patient.DateOfBirth.Year;

                if (prescription.Patient.DateOfBirth.Date > today.AddYears(-patientsAge)) patientsAge--;

                foreach (var item in prescriptionItems)
                {
                    if( item is Treatment treatment)
                    {
                        if(patientsAge < treatment.AgeMinimum || patientsAge > treatment.AgeMaximum) Services.Instance.AddErrorCode(errorCodes, Services.TreatmentInvalidAge);
                    }
                    else if (item is Exercise exercise)
                    {
                        if (patientsAge < exercise.AgeMinimum || patientsAge > exercise.AgeMaximum) Services.Instance.AddErrorCode(errorCodes, Services.ExerciseInvalidAge);
                    }
                }

                requestList = new List<object> { request, prescriptionItems, errorCodes };
                return base.Validate(requestList) ?? errorCodes;
            }

            throw new NotSupportedException($"Invalid type {request.GetType()}!");
        }
    }
}