using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using ServicesLibrary.DifferentServices;
using ServicesLibrary.DTOs;
using ServicesLibrary.Validators.FormValidators;
using ServicesLibrary.Validators.PrescriptionValidators;
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
            AgeMinimumNotValid = 16,
            AgeMaximumNotValid = 17,
            PriceNotValid = 18;

        #endregion

        #region LoggingIn

        public const int EmailDoesntExist = 1, PasswordDoesntMatch = 2;

        #endregion

        #region TherapySessionCreation

        public const int PatientUnavailable = 1, TherapistUnavailable = 2, PatientRequired = 3, AtLeastOneTreatment = 4;

        #endregion

        #region PrescriptionCreation

        public const int TreatmentInvalidAge = 1, ExerciseInvalidAge = 2, IncompatibleMedicine = 3, IncompatibleDisease = 4, MissingBodyPart = 5;

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
            BaseValidator validator = new StringEmptyValidator(NameRequired, ref errorCodes);
            validator.Validate(name);
            validator = new StringEmptyValidator(PhoneNumberRequired, ref errorCodes);
            validator.SetNext(new StringIsNumberValidator(PhoneNumberNotANumber, ref errorCodes)).SetNext(
                new StringLengthValidator(PhoneNumberWrongLength, ref errorCodes,
                    PhoneNumberMinimumLength,
                    PhoneNumberMaximumLength));
            validator.Validate(phoneNumberString);
            validator = new StringEmptyValidator(HealthUserNumberRequired, ref errorCodes);
            validator.SetNext(new StringIsNumberValidator(HealthUserNumberNotANumber, ref errorCodes) )
                .SetNext(new StringLengthValidator(HealthUserNumberWrongLength, ref errorCodes,
                    HealthUserNumberMinimumLength, HealthUserNumberMaximumLength)).SetNext(
                    new StringUniqueValidator(HealthUserNumberAlreadyExists, ref errorCodes,
                        _userService.GetAllUsers().Select(e => e.HealthUserNumber.ToString())));
            validator.Validate(healthUserNumberString);
            validator = new StringEmptyValidator(EmailRequired, ref errorCodes);
            validator.SetNext(new EmailFormatValidator(EmailNotValid, ref errorCodes)).SetNext(
                new StringUniqueValidator(EmailAlreadyExists, ref errorCodes,
                    _userService.GetAllUsers().Select(e => e.Email)));
            validator.Validate(email);
            validator = new StringEmptyValidator(PasswordRequired, ref errorCodes);
            validator.Validate(password);
            if (userType == "Therapist")
            {
                validator = new TherapistOldEnoughValidator(TherapistNotOldEnough, ref errorCodes);
                validator.Validate(new TherapistDTO {DateOfBirth = dateOfBirth});
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

        public void CreatePrescription(string patient, string description, DateTime startDate, DateTime endDate,
            ICollection<string> treatments, ICollection<string> medicines, ICollection<string> exercises)
        {
            var prescriptionItems = GetPrescriptionItemsFromStrings(treatments, medicines, exercises);

            var patientId = int.Parse(patient.Split(" - ", StringSplitOptions.RemoveEmptyEntries).First());

            _prescriptionService.CreatePrescription((Patient)UserService.Instance.GetUserById(patientId), description, startDate, endDate, prescriptionItems);
        }

        public ICollection<PrescriptionItem> GetPrescriptionItemsFromStrings(ICollection<string> treatments, ICollection<string> medicines, ICollection<string> exercises)
        {
            var prescriptionItems = new List<PrescriptionItem>();

            foreach (var exerciseString in exercises)
            {
                prescriptionItems.Add(PrescriptionItemService.Instance.GetExerciseByName(exerciseString));
            }

            foreach (var treatmentString in treatments)
            {
                prescriptionItems.Add(PrescriptionItemService.Instance.GetTreatmentByName(treatmentString));
            }

            foreach (var medicineString in medicines)
            {
                prescriptionItems.Add(PrescriptionItemService.Instance.GetMedicineByName(medicineString));
            }
            return prescriptionItems;
        }

        public IEnumerable<int> CheckPrescriptionCreation(string patient, string description, DateTime startDate, DateTime endDate, ICollection<string> treatments, ICollection<string> medicines, ICollection<string> exercises)
        {
            var errorCodes = new List<int>();
            if (patient == "")
            {
                errorCodes.Add(PatientRequired);
            }
            else
            {
                var patientId = int.Parse(patient.Split(" - ", StringSplitOptions.RemoveEmptyEntries).First());
                var prescriptionItems = GetPrescriptionItemsFromStrings(treatments, medicines, exercises);
                
                var validator = new AgeValidator();

                var allergyValidator = new AllergyValidator();
                var existingDiseaseValidator = new ExistingDiseaseValidator();
                var missingBodyPartValidator = new MissingBodyPartValidator();
                //var timeConstraintsValidator = new TimeConstraintsValidator();
                //missingBodyPartValidator.SetNext(timeConstraintsValidator);
                existingDiseaseValidator.SetNext(missingBodyPartValidator);
                allergyValidator.SetNext(existingDiseaseValidator);
                validator.SetNext(allergyValidator);

                var validateResult = validator.Validate(new List<object>
                {
                    new Prescription
                    {
                        Patient = (Patient) UserService.Instance.GetUserById(patientId),
                        Author = (HealthCareProfessional) UserService.Instance.GetUserById(UserService.Instance.LoggedInUserId),
                        StartDate = startDate, EndDate = endDate
                    },
                    prescriptionItems,
                    errorCodes
                });

                errorCodes = (List<int>)validateResult;
            }

            return errorCodes;
            //_prescriptionService.CreatePrescription((Patient)UserService.Instance.GetUserById(patientId), description,
            //    startDate, endDate, prescriptionItems);
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

        public IEnumerable<int> CheckExerciseOrTreatmentCreation(string name, string description, string ageMinimum,
            string ageMaximum)
        {
            var errorCodes = new List<int>();
            BaseValidator validator = new StringEmptyValidator(NameRequired, ref errorCodes);
            validator.Validate(name);
            validator = new StringEmptyValidator(DescriptionRequired, ref errorCodes);
            validator.Validate(description);
            validator = new StringEmptyValidator(AgeMinimumNotValid, ref errorCodes);
            validator.SetNext(new StringIsNumberValidator(AgeMinimumNotValid, ref errorCodes));
            validator.Validate(ageMinimum);
            validator = new StringEmptyValidator(AgeMaximumNotValid, ref errorCodes);
            validator.SetNext(new StringIsNumberValidator(AgeMaximumNotValid, ref errorCodes));
            validator.Validate(ageMaximum);
            //if (string.IsNullOrWhiteSpace(name)) errorCodes.Add(NameRequired);
            //if (string.IsNullOrWhiteSpace(description)) errorCodes.Add(DescriptionRequired);

            //if (!int.TryParse(ageMinimum, out _)) errorCodes.Add(AgeMinimumNotValid);
            //else if (string.IsNullOrWhiteSpace(ageMinimum)) errorCodes.Add(AgeMinimumNotValid);

            //if (!int.TryParse(ageMaximum, out _)) errorCodes.Add(AgeMaximumNotValid);
            //else if (string.IsNullOrWhiteSpace(ageMaximum)) errorCodes.Add(AgeMaximumNotValid);

            return errorCodes;
        }

        public IEnumerable<int> CheckMedicineCreation(string name, string description, string price)
        {
            var errorCodes = new List<int>();
            BaseValidator validator = new StringEmptyValidator(NameRequired, ref errorCodes);
            validator.Validate(name);
            validator = new StringEmptyValidator(DescriptionRequired, ref errorCodes);
            validator.Validate(description);
            validator = new StringEmptyValidator(PriceNotValid, ref errorCodes);
            validator.SetNext(new StringIsNumberValidator(PriceNotValid, ref errorCodes));
            validator.Validate(price);

            //if (string.IsNullOrWhiteSpace(name)) errorCodes.Add(NameRequired);
            //if (string.IsNullOrWhiteSpace(description)) errorCodes.Add(DescriptionRequired);

            //if (!double.TryParse(price, out _)) errorCodes.Add(PriceNotValid);
            //else if (string.IsNullOrWhiteSpace(price)) errorCodes.Add(PriceNotValid);

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

        public IEnumerable<string> GetExercises()
        {
            return _prescriptionItemService.GetAllExercises().Select(e => e.Name);
        }

        public IEnumerable<string> GetMedicine()
        {
            return _prescriptionItemService.GetAllMedicine().Select(e => e.Name);
        }

        public IEnumerable<string> GetTreatments()
        {
            return _prescriptionItemService.GetAllTreatments().Select(e => e.Name);
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

            BaseValidator validator = new StringEmptyValidator(PatientRequired, ref errorCodes);
            validator.Validate(patient);
            var patientId = int.Parse(patient.Split(" - ", StringSplitOptions.RemoveEmptyEntries).First());
            //if (!_userService.IsPatientAvailable(patientId, sessionDate, sessionTime, estimatedDuration))
            //{
            //    errorCodes.Add(PatientUnavailable);
            //}
            validator = new PatientAvailabilityValidator(PatientUnavailable, ref errorCodes);
            validator.SetNext(new TherapistAvailabilityValidator(TherapistUnavailable, ref errorCodes));
            validator.Validate(new TherapySession()
            {
                Patient = (Patient) UserService.Instance.GetUserById(patientId),
                Therapist = (Therapist) UserService.Instance.GetUserById(UserService.Instance.LoggedInUserId),
                DateTime = sessionDate.Date.Add(sessionTime.TimeOfDay), EstimatedDuration = estimatedDuration
            });
            //List<object> validateResultList = (List<object>) validateResult;

            //if (!_userService.IsTherapistAvailable(sessionDate, sessionTime, estimatedDuration))
            //{
            //    errorCodes.Add(TherapistUnavailable);
            //}
            validator = new EnumerableEmptyValidator(AtLeastOneTreatment, ref errorCodes);
            validator.Validate(treatments);
            //if (!treatments.Any())
            //{
            //    errorCodes.Add(AtLeastOneTreatment);
            //}

            return errorCodes;
        }

        public void CreateTherapySession(string patient, DateTime sessionDate, DateTime sessionTime,
            IEnumerable<string> treatments, TimeSpan estimatedDuration)
        {
            var patientId = int.Parse(patient.Split(" - ", StringSplitOptions.RemoveEmptyEntries).First());
            var treatmentsList = new List<Treatment>();
            foreach (var treatmentString in treatments)
            {
                treatmentsList.Add(
                    PrescriptionItemService.Instance.GetTreatmentByNameBodyPartAndDurationString(treatmentString));
            }

            TherapySessionService.Instance.AddTherapySession((Patient) UserService.Instance.GetUserById(patientId),
                sessionDate.Date.Add(sessionTime.TimeOfDay), treatmentsList, estimatedDuration);
        }

        public IEnumerable<string> GetPastTherapySessionsOfLoggedInTherapist()
        {
            var pastTherapySessions = _therapySessionService.GetTherapySessionsBeforeDate(
                _therapySessionService.GetAllTherapySessionsOfTherapist(UserService.Instance.LoggedInUserId),
                new DateTime(2022, 1, 1));
            var therapySessionsStrings = new List<string>();
            foreach (var pastTherapySession in pastTherapySessions)
            {
                therapySessionsStrings.Add(
                    $"{pastTherapySession.Id} | {_userService.GetUserById(pastTherapySession.PatientId).FullName}{Environment.NewLine}{pastTherapySession.DateTime:dddd dd/MM/yyyy HH:mm}");
            }

            return therapySessionsStrings;
        }

        public void SelectTherapySession(string therapySessionText)
        {
            var therapySessionParameters =
                therapySessionText.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
            var therapySessionId = int.Parse(therapySessionParameters[0]);
            _therapySessionService.SelectedTherapySessionId = therapySessionId;
        }

        public string GetSelectedTherapySessionBaseInfo()
        {
            var therapySession = _therapySessionService.GetSelectedTherapySession();
            return
                $"{therapySession.Id} | {_userService.GetUserById(therapySession.PatientId).FullName} | {therapySession.DateTime:dddd dd/MM/yyyy HH:mm}";
        }

        public IEnumerable<IEnumerable<string>> GetSelectedTherapySessionTreatments()
        {
            var treatments = new List<List<string>>();
            foreach (var therapySessionHasTreatmentsInstance in _therapySessionService
                .GetTherapySessionHasTreatmentsEnumerableByTherapySessionId(_therapySessionService
                    .SelectedTherapySessionId))
            {
                var treatment =
                    _prescriptionItemService.GetTreatmentById(therapySessionHasTreatmentsInstance.TreatmentId);
                treatments.Add(new List<string>
                {
                    treatment.Name,
                    treatment.Description,
                    treatment.BodyPart.ToString(),
                    $"{treatment.Duration:hh\\:mm\\:ss}"
                });
            }

            return treatments;
        }

        public string GetTreatmentNote(string treatmentString)
        {
            return _therapySessionService.GetTherapySessionHasTreatmentsBySessionIdTreatmentId(
                _therapySessionService.SelectedTherapySessionId,
                _prescriptionItemService.GetTreatmentByNameBodyPartAndDurationString(treatmentString).Id).Note;
        }

        public bool GetTreatmentCompletedStatus(string treatmentString)
        {
            return _therapySessionService.GetTherapySessionHasTreatmentsBySessionIdTreatmentId(
                    _therapySessionService.SelectedTherapySessionId,
                    _prescriptionItemService.GetTreatmentByNameBodyPartAndDurationString(treatmentString).Id)
                .CompletedTreatment;
        }

        public string GetSelectedTherapySessionNote()
        {
            return _therapySessionService.GetSelectedTherapySession().Note;
        }


        public IEnumerable<Prescription> GetPrescriptionByPatientId()
        {
            return _prescriptionService.GetPrescriptionByPatientId();
        }

        public IEnumerable<Prescription> GetPrescriptionByDate(DateTime _date)
        {
            return _prescriptionService.GetPrescriptionByDate(_date);
        }

        public IEnumerable<TherapySession> GetSessionsByTherapistId(DateTime _date)
        {
            return _therapySessionService.GetSessionsByTherapistId(_date);
        }

        public IEnumerable<TherapySession> GetSessionsByPatientId(DateTime _date)
        {
            return _therapySessionService.GetSessionsByPatientId(_date);
        }

        public User GetUserById(int id)
        {
            return _userService.GetUserById(id);
        }

        public IEnumerable<PrescriptionHasPrescriptionItems> GetPrescriptionItems(int pres_id)
        {
            return _prescriptionItemService.GetPrescriptionItems(pres_id);
        }

        public Medicine GetMedicineByItemId(int item_id)
        {
            return _prescriptionItemService.GetMedicineByItemId(item_id);
        }

        public Exercise GetExerciseByItemId(int item_id)
        {
            return _prescriptionItemService.GetExerciseByItemId(item_id);
        }

        public bool VerifyIfIsMedicine(int item_id)
        {
            return _prescriptionItemService.VerifyIfIsMedicine(item_id);
        }

        public bool VerifyIfIsExercise(int item_id)
        {
            return _prescriptionItemService.VerifyIfIsExercise(item_id);
        }

        public IEnumerable<string> GetPatientPrescriptions()
        {
            var prescriptions = new List<string>();
            foreach (var prescription in
                _prescriptionService.GetPrescriptionsOfPatientById(_userService.LoggedInUserId)
                    .OrderBy(e => e.StartDate))
            {
                prescriptions.Add(
                    $"{prescription.Id} | Author: {_userService.GetUserById(prescription.AuthorId).FullName} | From {prescription.StartDate:dd/MM/yyyy} To {prescription.EndDate:dd/MM/yyyy}");
            }

            return prescriptions;
        }

        public void SelectPrescriptions(IEnumerable<string> prescriptions)
        {
            _prescriptionService.SelectedPrescriptions = new List<Prescription>();
            foreach (var prescription in prescriptions)
            {
                var prescriptionSplit = prescription.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
                _prescriptionService.AddSelectedPrescriptionById(int.Parse(prescriptionSplit[0]));
            }
        }

        public IEnumerable<string> GetHealthCareProfessionals()
        {
            var professionals = new List<string>();
            foreach (var healthCareProfessional in _userService.GetAllHealthCareProfessionals())
            {
                professionals.Add($"{healthCareProfessional.Id} - {healthCareProfessional.FullName}");
            }

            return professionals;
        }

        public void AddPermissionToHealthCareProfessionals(IEnumerable<string> professionals)
        {
            foreach (var prescription in _prescriptionService.SelectedPrescriptions)
            {
                foreach (var professional in professionals)
                {
                    var professionalSplit = professional.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                    var healthCareProfessional =
                        (HealthCareProfessional) _userService.GetUserById(int.Parse(professionalSplit[0]));
                    if (!_prescriptionService.CanHealthCareProfessionalViewPrescription(prescription,
                        healthCareProfessional))
                    {
                        _prescriptionService.AddHealthCareProfessionalAsViewerToPrescription(prescription,
                            healthCareProfessional);
                    }
                }
            }
        }
    }
}