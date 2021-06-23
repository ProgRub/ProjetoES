using System;
using System.Collections.Generic;
using System.Linq;
using ServicesLibrary.DTOs;

namespace ServicesLibrary.Validators.PrescriptionValidators
{
    public class AgeValidator : BaseValidator
    {
        public AgeValidator(int errorCode, ref List<int> errorCodes) : base(errorCode, ref errorCodes)
        {
        }

        public override bool RequestIsValid(object request)
        {
            switch (request)
            {
                case PrescriptionDTO prescription:
                {
                    var today = DateTime.Today;
                    var patientsAge = today.Year - prescription.Patient.DateOfBirth.Year;
                    if (prescription.Patient.DateOfBirth.Date > today.AddYears(-patientsAge)) patientsAge--;

                    if (prescription.Exercises.Any(prescriptionExercise =>
                        patientsAge < prescriptionExercise.AgeMinimum ||
                        patientsAge > prescriptionExercise.AgeMaximum))
                    {
                        return false;
                    }

                    return prescription.Treatments.All(prescriptionTreatment =>
                        patientsAge >= prescriptionTreatment.AgeMinimum &&
                        patientsAge <= prescriptionTreatment.AgeMaximum);
                }
                case TherapySessionDTO therapySession:
                {
                    var today = DateTime.Today;
                    var patientsAge = today.Year - therapySession.Patient.DateOfBirth.Year;
                    if (therapySession.Patient.DateOfBirth.Date > today.AddYears(-patientsAge)) patientsAge--;

                    return therapySession.Treatments.All(treatment =>
                        patientsAge >= treatment.AgeMinimum && patientsAge <= treatment.AgeMaximum);
                }
                default:
                    throw new NotSupportedException($"Invalid type {request.GetType()}!");
            }
        }
    }
}