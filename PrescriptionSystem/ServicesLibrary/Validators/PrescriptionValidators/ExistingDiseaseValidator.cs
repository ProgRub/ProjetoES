using System.Collections.Generic;
using ServicesLibrary.DifferentServices;
using System;
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
                    foreach (var incompatibleMedicalCondition in medicine.IncompatibleDiseases)
                    {
                        if (prescription.Patient.Diseases.Any(disease => disease.Id == incompatibleMedicalCondition.Id))
                        {
                            return false;
                        }
                    }
                }

                return true;
            }

            throw new NotSupportedException($"Invalid type {request.GetType()}!");
        }
    }
}