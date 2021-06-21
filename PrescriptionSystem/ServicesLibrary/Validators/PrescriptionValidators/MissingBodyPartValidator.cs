using System.Collections.Generic;
using System;
using ServicesLibrary.DTOs;

namespace ServicesLibrary.Validators.PrescriptionValidators
{
    public class MissingBodyPartValidator : BaseValidator
    {
        public MissingBodyPartValidator(int errorCode, ref List<int> errorCodes) : base(errorCode, ref errorCodes)
        {
        }

        public override bool RequestIsValid(object request)
        {
            if (request is PrescriptionDTO prescription)
            {
                foreach (var treatment in prescription.Treatments)
                {
                    foreach (var missingBodyPart in prescription.Patient.MissingBodyParts)
                    {
                        if (missingBodyPart == treatment.BodyPart) return false;
                    }
                }

                return true;
            }
            if (request is TherapySessionDTO therapySession)
            {
                foreach (var treatment in therapySession.Treatments)
                {
                    foreach (var missingBodyPart in therapySession.Patient.MissingBodyParts)
                    {
                        if (missingBodyPart == treatment.BodyPart) return false;
                    }
                }

                return true;
            }

            throw new NotSupportedException($"Invalid type {request.GetType()}!");
        }
    }
}