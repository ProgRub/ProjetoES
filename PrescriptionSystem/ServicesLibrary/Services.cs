using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
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
            EmailNotValid = 11,
            EmailAlreadyExists = 12,
            HealthUserNumberAlreadyExists = 13,
            TherapistNotOldEnough=14;

        #endregion

        public const int PhoneNumberMinimumLength = 9, PhoneNumberMaximumLength = 9;
        public const int HealthUserNumberMinimumLength = 9, HealthUserNumberMaximumLength = 9;
        private const int Patient = 0, Therapist = 1;

        #region Services

        private MedicalConditionService _medicalConditionService;
        private UserService _userService;
        private PrescriptionItemService _prescriptionItemService;
        private PrescriptionService _prescriptionService;
        private TherapySessionService _therapySessionService;

        #endregion
        

        private Services()
        {
            _medicalConditionService = new MedicalConditionService();
            _userService = new UserService();
            _prescriptionService = new PrescriptionService();
            _prescriptionItemService = new PrescriptionItemService();
            _therapySessionService = new TherapySessionService();
        }

        public static Services Instance { get; } = new Services();

        public IEnumerable<int> CheckUserRegistration(string name, DateTime dateOfBirth, string phoneNumberParameter,
            string healthUserNumberParameter, string email,
            string password, string userType)
        {
            var phoneNumberString = string.Join("",
                phoneNumberParameter.Split(new char[0], StringSplitOptions.RemoveEmptyEntries));
            var healthUserNumberString = string.Join("",
                healthUserNumberParameter.Split(new char[0], StringSplitOptions.RemoveEmptyEntries));
            var errorCodes = new List<int>();
            if (string.IsNullOrWhiteSpace(name)) errorCodes.Add(NameRequired);
            if (string.IsNullOrWhiteSpace(phoneNumberString)) errorCodes.Add(PhoneNumberRequired);
            else if (phoneNumberString.Length < PhoneNumberMinimumLength ||
                     phoneNumberString.Length > PhoneNumberMaximumLength)
                errorCodes.Add(PhoneNumberWrongLength);
            else if (!int.TryParse(phoneNumberString, out _)) errorCodes.Add(PhoneNumberNotANumber);
            if (string.IsNullOrWhiteSpace(healthUserNumberString)) errorCodes.Add(HealthUserNumberRequired);
            else if (healthUserNumberString.Length < HealthUserNumberMinimumLength ||
                     healthUserNumberString.Length > HealthUserNumberMaximumLength)
                errorCodes.Add(HealthUserNumberWrongLength);
            else if (!int.TryParse(healthUserNumberString, out var healthUserNumber))
                errorCodes.Add(HealthUserNumberNotANumber);
            else if (!_userService.IsHealthUserNumberUnique(healthUserNumber))
                errorCodes.Add(HealthUserNumberAlreadyExists);
            if (string.IsNullOrWhiteSpace(email)) errorCodes.Add(EmailRequired);
            else if (!(new EmailAddressAttribute().IsValid(email))) errorCodes.Add(EmailNotValid);
            else if(!_userService.IsEmailUnique(email)) errorCodes.Add(EmailAlreadyExists);
            if (string.IsNullOrWhiteSpace(password)) errorCodes.Add(PasswordRequired);
            if (userType == "Therapist")
            {
                if (!_userService.IsTherapistOldEnough(dateOfBirth))
                {
                    errorCodes.Add(TherapistNotOldEnough);
                }
            }
            return errorCodes;
        }

        public void RegisterUser(string name, DateTime dateOfBirth, int phoneNumber,
            int healthUserNumber, string email,
            string password, IEnumerable<string> allergies, IEnumerable<string> diseases,
            IEnumerable<string> missingBodyParts, string userType)
        {
            Debug.WriteLine("BEFORE");
            _userService.RegisterUser(name, dateOfBirth, phoneNumber, healthUserNumber, email,
                password, allergies, diseases, missingBodyParts, userType);
            Debug.WriteLine("AFTER");
        }

        public int Login(string email, string password)
        {
            return Ok;
        }

        public IEnumerable<string> GetAllergies()
        {
            return _medicalConditionService.GetAllergies().Select(e => e.Name);
        }

        public IEnumerable<string> GetDiseases()
        {
            return _medicalConditionService.GetDiseases().Select(e => e.Name);
        }

        internal MedicalCondition GetMedicalConditionByName(string name)
        {
            return _medicalConditionService.GetMedicalConditionByName(name);
        }
    }
}