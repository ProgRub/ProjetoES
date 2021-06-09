using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Net;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using ServicesLibrary.DifferentServices;
using ServicesLibrary.Validators.TherapySessionValidators;

namespace ServicesLibrary
{
    public class Services
    {
        public const int Ok = 0;

        #region ErrorConstants

        #region Registration

        public const int MiscError = 1,
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
            TherapistNotOldEnough = 14,
            DescriptionRequired = 15,
            AgeMininumNotValid = 16,
            AgeMaxinumNotValid = 17,
            PriceNotValid = 18;

        #endregion

        #region LoggingIn

        public const int EmailDoesntExist = 1, PasswordDoesntMatch = 2;

        #endregion

        #region TherapySessionCreation

        public const int PatientUnavailable = 1, TherapistUnavailable = 2, PatientRequired = 3, AtLeastOneTreatment = 4;

        #endregion

        #endregion

        public const int PhoneNumberMinimumLength = 9, PhoneNumberMaximumLength = 9;
        public const int HealthUserNumberMinimumLength = 9, HealthUserNumberMaximumLength = 9;
        public const int Patient = 15, Therapist = 16;

        #region Services

        private readonly MedicalConditionService _medicalConditionService;
        private readonly UserService _userService;
        private readonly PrescriptionItemService _prescriptionItemService;
        private readonly PrescriptionService _prescriptionService;
        private readonly TherapySessionService _therapySessionService;

        #endregion


        private Services()
        {
            _medicalConditionService = MedicalConditionService.Instance;
            _userService = UserService.Instance;
            _prescriptionService = PrescriptionService.Instance;
            _prescriptionItemService = PrescriptionItemService.Instance;
            _therapySessionService = TherapySessionService.Instance;
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
            else if (!_userService.IsEmailUnique(email)) errorCodes.Add(EmailAlreadyExists);
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
            _userService.RegisterUser(name, dateOfBirth, phoneNumber, healthUserNumber, email,
                password, allergies, diseases, missingBodyParts, userType);
        }

        public void CreateExercisePrescriptionItem(string name, string description, int ageMinimum, int ageMaximum,
            TimeSpan duration, IEnumerable<string> bodyParts)
        {
            _prescriptionItemService.CreateExercisePrescriptionItem(name, description, ageMinimum, ageMaximum, duration,
                bodyParts);
        }

        public void CreateMedicinePrescriptionItem(string name, string description, double price,
            IEnumerable<string> allergies, IEnumerable<string> diseases)
        {
            _prescriptionItemService.CreateMedicinePrescriptionItem(name, description, price, allergies, diseases);
        }

        public void CreateTreatmentPrescriptionItem(string name, string description, int ageMinimum, int ageMaximum,
            TimeSpan duration, string bodyPart)
        {
            _prescriptionItemService.CreateTreatmentPrescriptionItem(name, description, ageMinimum, ageMaximum,
                duration, bodyPart);
        }

        public IEnumerable<int> CheckExerciseAndTreatmentCreation(string name, string description, string ageMinimum,
            string ageMaximum)
        {
            var errorCodes = new List<int>();

            if (string.IsNullOrWhiteSpace(name)) errorCodes.Add(NameRequired);
            if (string.IsNullOrWhiteSpace(description)) errorCodes.Add(DescriptionRequired);

            if (!int.TryParse(ageMinimum, out _)) errorCodes.Add(AgeMininumNotValid);
            else if (string.IsNullOrWhiteSpace(ageMinimum)) errorCodes.Add(AgeMininumNotValid);

            if (!int.TryParse(ageMaximum, out _)) errorCodes.Add(AgeMaxinumNotValid);
            else if (string.IsNullOrWhiteSpace(ageMaximum)) errorCodes.Add(AgeMaxinumNotValid);

            return errorCodes;
        }

        public IEnumerable<int> CheckMedicineCreation(string name, string description, string price)
        {
            var errorCodes = new List<int>();

            if (string.IsNullOrWhiteSpace(name)) errorCodes.Add(NameRequired);
            if (string.IsNullOrWhiteSpace(description)) errorCodes.Add(DescriptionRequired);

            if (!double.TryParse(price, out _)) errorCodes.Add(PriceNotValid);
            else if (string.IsNullOrWhiteSpace(price)) errorCodes.Add(PriceNotValid);

            return errorCodes;
        }

        public int Login(string email, string password)
        {
            if (!_userService.IsUserEmailInDatabase(email)) return EmailDoesntExist;
            if (!_userService.DoesPasswordCorrespondToEmail(email, password)) return PasswordDoesntMatch;
            return _userService.LogIn(email, password);
        }

        public IEnumerable<string> GetAllergies()
        {
            return _medicalConditionService.GetAllergies().Select(e => e.Name);
        }

        public IEnumerable<string> GetDiseases()
        {
            return _medicalConditionService.GetDiseases().Select(e => e.Name);
        }

        public void LoadDatabase()
        {
            _userService.LoadDBHelpFunction();
        }

        public IEnumerable<string> GetAllPatients()
        {
            var patients = _userService.GetAllPatients();
            var patientsAsStrings = new List<string>();
            foreach (var patient in patients)
            {
                patientsAsStrings.Add($"{patient.Id} - {patient.FullName}");
            }

            return patientsAsStrings;
        }

        public IDictionary<string, TimeSpan> GetAllTreatments()
        {
            var treatments = _prescriptionItemService.GetAllTreatments();
            var treatmentsAsDict = new Dictionary<string, TimeSpan>();
            foreach (var treatment in treatments)
            {
                treatmentsAsDict.Add($"{treatment.Name} | {treatment.BodyPart} | {treatment.Duration}",
                    treatment.Duration);
            }

            return treatmentsAsDict;
        }

        public IEnumerable<int> CheckTherapySessionCreation(string patient, DateTime sessionDate, DateTime sessionTime,
            IEnumerable<string> treatments, TimeSpan estimatedDuration)
        {
            var errorCodes = new List<int>();
            if (patient == "")
            {
                errorCodes.Add(PatientRequired);
            }
            else
            {
                var patientId = int.Parse(patient.Split(" - ", StringSplitOptions.RemoveEmptyEntries).First());
                //if (!_userService.IsPatientAvailable(patientId, sessionDate, sessionTime, estimatedDuration))
                //{
                //    errorCodes.Add(PatientUnavailable);
                //}
                var validator = new PatientAvailabilityValidator();
                validator.SetNext(new TherapistAvailabilityValidator());
                var validateResult = validator.Validate(new List<object>
                {
                    new TherapySession
                    {
                        Patient = (Patient) UserService.Instance.GetUserById(patientId),
                        Therapist = (Therapist) UserService.Instance.GetUserById(UserService.Instance.LoggedInUserId),
                        DateTime = sessionDate.Date.Add(sessionTime.TimeOfDay), EstimatedDuration = estimatedDuration
                    },
                    errorCodes
                });
                //List<object> validateResultList = (List<object>) validateResult;
                errorCodes = (List<int>) validateResult;
            }

            //if (!_userService.IsTherapistAvailable(sessionDate, sessionTime, estimatedDuration))
            //{
            //    errorCodes.Add(TherapistUnavailable);
            //}

            if (!treatments.Any())
            {
                errorCodes.Add(AtLeastOneTreatment);
            }

            return errorCodes;
        }

        public void CreateTherapySession(string patient, DateTime sessionDate, DateTime sessionTime,
            IEnumerable<string> treatments, TimeSpan estimatedDuration)
        {
            var patientId = int.Parse(patient.Split(" - ", StringSplitOptions.RemoveEmptyEntries).First());
            var treatmentsList = new List<Treatment>();
            foreach (var treatmentString in treatments)
            {
                var treatmentStringSplit = treatmentString.Split(" | ", StringSplitOptions.RemoveEmptyEntries);//Order of info: name -> bodyPart -> Duration
                treatmentsList.Add(PrescriptionItemService.Instance.GetTreatmentByNameBodyPartAndDuration(
                    treatmentStringSplit[0], (BodyPart) Enum.Parse(typeof(BodyPart), treatmentStringSplit[1]),
                    TimeSpan.Parse(treatmentStringSplit[2])));
            }
            TherapySessionService.Instance.AddTherapySession((Patient) UserService.Instance.GetUserById(patientId),
                sessionDate.Date.Add(sessionTime.TimeOfDay), treatmentsList, estimatedDuration);
        }
    }
}