using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using ComponentsLibrary.Entities;
using ServicesLibrary.DifferentServices;

namespace ServicesLibrary
{
    public class Services
    {
        #region ErrorConstants

        public const int Ok = 0,
            MiscError = 1,
            NameRequired = 2,
            PhoneNumberRequired = 3,
            HealthUserNumberRequired = 4,
            EmailRequired = 5,
            PasswordRequired = 6,
            PhoneNumberWrongLength = 7,
            PhoneNumberNotANumber = 8,
            HealthUserNumberWrongLength = 9,
            HealthUserNumberNotANumber = 10,
            EmailNotValid = 11;

        #endregion

        public const int PhoneNumberMinimumLength = 9, PhoneNumberMaximumLength = 9;
        public const int HealthUserNumberMinimumLength = 9, HealthUserNumberMaximumLength = 9;
        private const int Patient = 0, Therapist = 1;

        #region Services

        private MedicalConditionService _medicalConditionService;
        private PatientService _patientService;
        private PrescriptionItemService _prescriptionItemService;
        private PrescriptionService _prescriptionService;
        private TherapistService _therapistService;
        private TherapySessionService _therapySessionService;

        #endregion

        private int _loggedInUserType;

        private Services()
        {
            _medicalConditionService = new MedicalConditionService();
            _patientService = new PatientService();
            _prescriptionService = new PrescriptionService();
            _prescriptionItemService = new PrescriptionItemService();
            _therapistService = new TherapistService();
            _therapySessionService = new TherapySessionService();
        }

        public static Services Instance { get; } = new Services();

        public IEnumerable<int> CheckUserRegistration(string name, DateTime dateOfBirth, string phoneNumberString,
            string healthUserNumberString, string email,
            string password, string userType)
        {
            int phoneNumber = 0, healthUserNumber = 0;
            IEnumerable<int> errorCodes = new List<int>();
            if (name == "") errorCodes.Append(NameRequired);
            if (phoneNumberString == "") errorCodes.Append(PhoneNumberRequired);
            else if (phoneNumberString.Length < PhoneNumberMinimumLength ||
                     phoneNumberString.Length > PhoneNumberMaximumLength)
                errorCodes.Append(PhoneNumberWrongLength);
            else if (!int.TryParse(phoneNumberString, out phoneNumber)) errorCodes.Append(PhoneNumberNotANumber);
            if (healthUserNumberString == "") errorCodes.Append(HealthUserNumberRequired);
            else if (healthUserNumberString.Length < HealthUserNumberMinimumLength ||
                     healthUserNumberString.Length > HealthUserNumberMaximumLength)
                errorCodes.Append(HealthUserNumberWrongLength);
            else if (!int.TryParse(healthUserNumberString, out healthUserNumber))
                errorCodes.Append(HealthUserNumberNotANumber);
            if (email == "") errorCodes.Append(EmailRequired);
            else if (!(new EmailAddressAttribute().IsValid(email))) errorCodes.Append(EmailNotValid);
            if (password == "") errorCodes.Append(PasswordRequired);
            if (errorCodes.Count() != 0)
            {
                return errorCodes;
            }

            switch (userType)
            {
                case "Patient":
                    return _patientService.CheckPatientRegistration(healthUserNumber, email);
                case "Therapist":
                    return _therapistService.CheckTherapistRegistration(dateOfBirth, healthUserNumber, email);
                default:
                    errorCodes.Append(MiscError);
                    return errorCodes;
            }
        }

        public void RegisterUser(string name, DateTime dateOfBirth, int phoneNumber,
            int healthUserNumber, string email,
            string password, IEnumerable<string> allergies, IEnumerable<string> diseases, string userType)
        {
            switch (userType)
            {
                case "Patient":
                    _patientService.RegisterPatient(name, dateOfBirth, phoneNumber, healthUserNumber, email,
                        password, allergies, diseases);
                    return;
                case "Therapist":
                    _therapistService.RegisterTherapist(name, dateOfBirth, phoneNumber, healthUserNumber,
                        email, password, allergies, diseases);
                    return;
            }
        }

        public int Login(string email, string password)
        {
            return Ok;
        }
    }
}