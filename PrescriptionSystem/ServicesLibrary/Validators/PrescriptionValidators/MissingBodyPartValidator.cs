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
                        //foreach (var missingBodyPart in UserService.Instance.GetUserMissingBodyPartsByUserId(TODO))
                        //{
                        //    if (missingBodyPart.User == prescription.Patient &&
                        //        missingBodyPart.BodyPart == treatment.BodyPart)
                        //        return false;
                        //}
                }

                return true;
            }

            throw new NotSupportedException($"Invalid type {request.GetType()}!");
        }
    }
}