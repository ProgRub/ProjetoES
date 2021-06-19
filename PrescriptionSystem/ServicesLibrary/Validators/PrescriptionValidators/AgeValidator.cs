using System;
using System.Collections.Generic;
using System.Diagnostics;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using ServicesLibrary.DifferentServices;

using System.Collections.Generic;
using ServicesLibrary.Validators.Prescription;

namespace ServicesLibrary.Validators.PrescriptionValidators
{
    public class AgeValidator:BaseValidator
    {

        public AgeValidator(int errorCode, ref List<int> errorCodes) : base(errorCode, ref errorCodes)
        {
        }

        public override bool RequestIsValid(object request)
        {

            if (request is  Prescription prescription)
            {
                var today = DateTime.Today;
                var patientsAge = today.Year - prescription.Patient.DateOfBirth.Year;

                if (prescription.Patient.DateOfBirth.Date > today.AddYears(-patientsAge)) patientsAge--;

                foreach (var item in prescriptionItems)
                {
                    if( item is Treatment treatment)
                    {
                        if(patientsAge < treatment.AgeMinimum || patientsAge > treatment.AgeMaximum) return false;
                    }
                    else if (item is Exercise exercise)
                    {
                        if (patientsAge < exercise.AgeMinimum || patientsAge > exercise.AgeMaximum) return false;
                    }
                }
                return true
            }

            throw new NotSupportedException($"Invalid type {request.GetType()}!");
        }
    }
}