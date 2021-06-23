using System.Collections.Generic;
using System;
using System.Linq;
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
            switch (request)
            {
                case PrescriptionDTO prescription when prescription.Patient.MissingBodyParts == null:
                    return true;
                case PrescriptionDTO prescription:
                {
                    foreach (var treatment in prescription.Treatments)
                    {
                        if (prescription.Patient.MissingBodyParts.Any(missingBodyPart =>
                            missingBodyPart == treatment.BodyPart))
                        {
                            return false;
                        }
                    }

                    foreach (var exercise in prescription.Exercises)
                    {
                        if (prescription.Patient.MissingBodyParts.Any(missingBodyPart =>
                            exercise.BodyParts.Contains(missingBodyPart)))
                        {
                            return false;
                        }
                    }

                    return true;
                }
                case TherapySessionDTO therapySession when therapySession.Patient.MissingBodyParts == null:
                    return true;
                case TherapySessionDTO therapySession:
                {
                    foreach (var treatment in therapySession.Treatments)
                    {
                        if (therapySession.Patient.MissingBodyParts.Any(missingBodyPart =>
                            missingBodyPart == treatment.BodyPart))
                        {
                            return false;
                        }
                    }

                    return true;
                }
                default:
                    throw new NotSupportedException($"Invalid type {request.GetType()}!");
            }
        }
    }
}