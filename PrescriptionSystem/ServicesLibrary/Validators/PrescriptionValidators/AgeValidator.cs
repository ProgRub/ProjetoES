using System;
using System.Collections.Generic;
using System.Diagnostics;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using ServicesLibrary.DifferentServices;
using ServicesLibrary.DTOs;

namespace ServicesLibrary.Validators.PrescriptionValidators
{
    public class AgeValidator:BaseValidator
    {

        public AgeValidator(int errorCode, ref List<int> errorCodes) : base(errorCode, ref errorCodes)
        {
        }

        public override bool RequestIsValid(object request)
        {

            if (request is  PrescriptionDTO prescription)
            {
                var today = DateTime.Today;
                var patientsAge = today.Year - prescription.Patient.DateOfBirth.Year;

                if (prescription.Patient.DateOfBirth.Date > today.AddYears(-patientsAge)) patientsAge--;
                
                foreach (var prescriptionExercise in prescription.Exercises)
                {
                        if (patientsAge < prescriptionExercise.AgeMinimum || patientsAge > prescriptionExercise.AgeMaximum) return false;
                }

                foreach (var prescriptionTreatment in prescription.Treatments)
                {

                    if (patientsAge < prescriptionTreatment.AgeMinimum || patientsAge > prescriptionTreatment.AgeMaximum) return false;
                }

                return true;
            }

            throw new NotSupportedException($"Invalid type {request.GetType()}!");
        }
    }
}