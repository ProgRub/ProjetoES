using System.Collections.Generic;

namespace ServicesLibrary.Validators.Prescription
{
    public class MissingBodyPartValidator : BaseValidator
    {

        public MissingBodyPartValidator(int errorCode, ref List<int> errorCodes) : base(errorCode, ref errorCodes)
        {
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using ServicesLibrary;
using ServicesLibrary.DifferentServices;
using ServicesLibrary.Validators;
using System;
using System.Collections.Generic;
using System.Diagnostics;

public class MissingBodyPartValidator : BaseValidator
{
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
                if (item is Treatment treatment)
                {
                   foreach(var missingBodyPart in UserService.Instance.GetMissingBodyParts())
                    {
                        if (missingBodyPart.User == prescription.Patient && missingBodyPart.BodyPart == treatment.BodyPart) errorCodes.Add(Services.MissingBodyPart);
                    }
                }
            }

            requestList = new List<object> { request, prescriptionItems, errorCodes };
            return base.Validate(requestList) ?? errorCodes;
        }

        public override bool RequestIsValid(object request)
        {
            throw new System.NotImplementedException();
        }
        throw new NotSupportedException($"Invalid type {request.GetType()}!");
    }
}