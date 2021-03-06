using System.Collections.Generic;
using ServicesLibrary.DifferentServices;
using System;
using System.Linq;
using ServicesLibrary.DTOs;

namespace ServicesLibrary.Validators.PrescriptionValidators
{
    public class AllergyValidator : BaseValidator
    {
        public AllergyValidator(int errorCode, ref List<int> errorCodes) : base(errorCode, ref errorCodes)
        {
        }

        public override bool RequestIsValid(object request)
        {
            if (request is PrescriptionDTO prescription)
            {
                foreach (var medicine in prescription.Medicines)
                {
                    foreach (var allergenic in medicine.IncompatibleAllergies)
                    {
                        if (prescription.Patient.Allergies.Any(allergy => allergy.Id == allergenic.Id))
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