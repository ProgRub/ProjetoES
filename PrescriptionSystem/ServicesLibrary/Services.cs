using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        private const int PhoneNumberMinimumLength = 9, PhoneNumberMaximumLength = 9;
        private const int HealthUserNumberMinimumLength = 9, HealthUserNumberMaximumLength = 9;

        #region Services

        private MedicalConditionService _medicalConditionService;
        private PatientService _patientService;
        private PrescriptionItemService _prescriptionItemService;
        private PrescriptionService _prescriptionService;
        private TherapistService _therapistService;
        private TherapySessionService _therapySessionService;

        #endregion

        private int _userType;

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

        public int RegisterUser(string name, DateTime dateOfBirth, string phoneNumberString,
            string healthUserNumberString, string email,
            string password, IEnumerable<string> allergies, IEnumerable<string> diseases, string userType)
        {
            if (name == "") return NameRequired;
            if (phoneNumberString == "") return PhoneNumberRequired;
            if (phoneNumberString.Length < PhoneNumberMinimumLength ||
                phoneNumberString.Length > PhoneNumberMaximumLength)
                return PhoneNumberWrongLength;
            if (!int.TryParse(phoneNumberString, out var phoneNumber)) return PhoneNumberNotANumber;
            if (healthUserNumberString == "") return HealthUserNumberRequired;
            if (healthUserNumberString.Length < HealthUserNumberMinimumLength ||
                healthUserNumberString.Length > HealthUserNumberMaximumLength)
                return HealthUserNumberWrongLength;
            if (!int.TryParse(healthUserNumberString, out var healthUserNumber)) return HealthUserNumberNotANumber;
            if (email == "") return EmailRequired;
            if (!(new EmailAddressAttribute().IsValid(email))) return EmailNotValid;
            if (password == "") return PasswordRequired;
            switch (userType)
            {
                case "Patient":
                    return _patientService.RegisterPatient(name, dateOfBirth, phoneNumber, healthUserNumber, email,
                        password,
                        allergies, diseases);
                case "Therapist":
                    return _therapistService.RegisterTherapist(name, dateOfBirth, phoneNumber, healthUserNumber,
                        email, password,
                        allergies, diseases);
                default:
                    return MiscError;
            }
        }

        public int Login(string email, string password)
        {
            return Ok;
        }
    }
}