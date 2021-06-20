using System;
using System.Collections.Generic;
using System.Linq;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using ServicesLibrary.DifferentServices;
using ServicesLibrary.DTOs;
using ServicesLibrary.Validators;
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

        public const int InvalidAge = 1, IncompatibleMedicine = 2, IncompatibleDisease = 5, MissingBodyPart = 6;

        #endregion

        #endregion

        public const int PhoneNumberMinimumLength = 9, PhoneNumberMaximumLength = 9;
        public const int HealthUserNumberMinimumLength = 9, HealthUserNumberMaximumLength = 9;
        public const int Patient = 15, Therapist = 16;

        #region Services

        private readonly MedicalConditionService _medicalConditionService;
        private readonly UserService _userService;
        private readonly PatientService _patientService;
        private readonly HealthCareProfessionalService _healthCareProfessionalService;
        private readonly TherapistService _therapistService;
        private readonly PrescriptionItemService _prescriptionItemService;
        private readonly PrescriptionService _prescriptionService;
        private readonly TherapySessionService _therapySessionService;

        #endregion


        private Services()
        {
            _medicalConditionService = MedicalConditionService.Instance;
            _userService = UserService.Instance;
            _patientService = PatientService.Instance;
            _healthCareProfessionalService = HealthCareProfessionalService.Instance;
            _therapistService = TherapistService.Instance;
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
            validator.SetNext(new StringIsIntegerValidator(PhoneNumberNotANumber, ref errorCodes)).SetNext(
                new StringLengthValidator(PhoneNumberWrongLength, ref errorCodes,
                    PhoneNumberMinimumLength,
                    PhoneNumberMaximumLength));
            validator.Validate(phoneNumberString);
            validator = new StringEmptyValidator(HealthUserNumberRequired, ref errorCodes);
            validator.SetNext(new StringIsIntegerValidator(HealthUserNumberNotANumber, ref errorCodes))
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
            string password, IEnumerable<MedicalConditionDTO> allergies, IEnumerable<MedicalConditionDTO> diseases,
            IEnumerable<string> missingBodyParts, string userType)
        {
            _userService.RegisterUser(name, dateOfBirth, phoneNumber, healthUserNumber, email,
                password, allergies, diseases, missingBodyParts, userType);
        }

        public void CreatePrescription(string patient, string description, DateTime startDate, DateTime endDate,
            ICollection<string> treatments, ICollection<string> medicines, ICollection<string> exercises, List<KeyValuePair<string, string>> recommendedTimes)
        {
            var prescriptionItems = GetPrescriptionItemsFromStrings(treatments, medicines, exercises);

            var patientId = int.Parse(patient.Split(" - ", StringSplitOptions.RemoveEmptyEntries).First());

            _prescriptionService.CreatePrescription((Patient) UserService.Instance.GetUserById(patientId), description,
                startDate, endDate, prescriptionItems, recommendedTimes);
        }

        public ICollection<PrescriptionItem> GetPrescriptionItemsFromStrings(ICollection<string> treatments,
            ICollection<string> medicines, ICollection<string> exercises)
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

        public IEnumerable<int> CheckPrescriptionCreation(string patient, string description, DateTime startDate,
            DateTime endDate, ICollection<string> treatments, ICollection<string> medicines,
            ICollection<string> exercises)
        {
            var errorCodes = new List<int>();
            BaseValidator validator = new StringEmptyValidator(PatientRequired, ref errorCodes);
            validator.Validate(patient);
            if (errorCodes.Any()) return errorCodes;
            var patientId = int.Parse(patient.Split(" - ", StringSplitOptions.RemoveEmptyEntries).First());
            var prescriptionItems = GetPrescriptionItemsFromStrings(treatments, medicines, exercises);
            var prescriptionDTO = new PrescriptionDTO
            {
                Patient = PatientDTO.ConvertPatientToDTO((Patient) UserService.Instance.GetUserById(patientId)),
                Author = HealthCareProfessionalDTO.ConvertHealthCareProfessionalToDTO(
                    (HealthCareProfessional) UserService.Instance.GetUserById(UserService.Instance
                        .LoggedInUserId)),
                StartDate = startDate,
                EndDate = endDate,
            };
            PrescriptionDTO.AddPrescriptionItemsToDTO(prescriptionDTO, prescriptionItems);
            validator = new AgeValidator(InvalidAge, ref errorCodes);
            validator.SetNext(new AllergyValidator(IncompatibleMedicine, ref errorCodes))
                .SetNext(new ExistingDiseaseValidator(IncompatibleDisease, ref errorCodes))
                .SetNext(new MissingBodyPartValidator(MissingBodyPart, ref errorCodes));
            validator.Validate(prescriptionDTO);

            return errorCodes;
        }

        public void CreateExercisePrescriptionItem(string name, string description, int ageMinimum, int ageMaximum,
            TimeSpan duration, IEnumerable<string> bodyParts)
        {
            _prescriptionItemService.CreateExercisePrescriptionItem(name, description, ageMinimum, ageMaximum, duration,
                bodyParts);
        }


        public void CreateMedicinePrescriptionItem(string name, string description, double price,
            IEnumerable<MedicalConditionDTO> allergies, IEnumerable<MedicalConditionDTO> diseases)
        {
            _prescriptionItemService.CreateMedicinePrescriptionItem(name, description, price,
                allergies.Select(e => _medicalConditionService.GetMedicalConditionById(e.Id)),
                diseases.Select(e => _medicalConditionService.GetMedicalConditionById(e.Id)));
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
            validator.SetNext(new StringIsIntegerValidator(AgeMinimumNotValid, ref errorCodes));
            validator.Validate(ageMinimum);
            validator = new StringEmptyValidator(AgeMaximumNotValid, ref errorCodes);
            validator.SetNext(new StringIsIntegerValidator(AgeMaximumNotValid, ref errorCodes));
            validator.Validate(ageMaximum);

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
            validator.SetNext(new StringIsFloatValidator(PriceNotValid, ref errorCodes));
            validator.Validate(price);

            return errorCodes;
        }

        public int Login(string email, string password)
        {
            if (!_userService.IsUserEmailInDatabase(email)) return EmailDoesntExist;
            if (!_userService.DoesPasswordCorrespondToEmail(email, password)) return PasswordDoesntMatch;
            return _userService.LogIn(email, password);
        }

        public IEnumerable<MedicalConditionDTO> GetAllergies()
        {
            return _medicalConditionService.GetAllergies()
                .Select(e => MedicalConditionDTO.ConvertMedicalConditionToDTO(e));
        }

        public IEnumerable<ExerciseDTO> GetExercises()
        {
            return _prescriptionItemService.GetAllExercises().Select(e => ExerciseDTO.ConvertExerciseToDTO(e));
        }

        public IEnumerable<MedicineDTO> GetMedicine()
        {
            return _prescriptionItemService.GetAllMedicine().Select(e => MedicineDTO.ConvertMedicineToDTO(e));
        }

        public IEnumerable<TreatmentDTO> GetTreatments()
        {
            return _prescriptionItemService.GetAllTreatments().Select(e => TreatmentDTO.ConvertTreatmentToDTO(e));
        }

        public IEnumerable<MedicalConditionDTO> GetDiseases()
        {
            return _medicalConditionService.GetDiseases()
                .Select(e => MedicalConditionDTO.ConvertMedicalConditionToDTO(e));
        }

        public void LoadDatabase()
        {
            _userService.LoadDBHelpFunction();
        }

        internal void SaveChanges() => _userService.SaveChanges();

        public IEnumerable<PatientDTO> GetAllPatients()
        {
            return _patientService.GetAll().Select(e => PatientDTO.ConvertPatientToDTO(e));
        }

        public IEnumerable<TreatmentDTO> GetAllTreatments()
        {
            return _prescriptionItemService.GetAllTreatments().Select(e => TreatmentDTO.ConvertTreatmentToDTO(e));
        }

        public IEnumerable<int> CheckTherapySessionCreation(PatientDTO patient, DateTime sessionDate,
            DateTime sessionTime,
            IEnumerable<TreatmentDTO> treatments, TimeSpan estimatedDuration)
        {
            var errorCodes = new List<int>();

            BaseValidator validator = new ObjectNotNullValidator(PatientRequired, ref errorCodes);
            validator.Validate(patient);
            if (errorCodes.Any()) return errorCodes;
            validator = new PatientAvailabilityValidator(PatientUnavailable, ref errorCodes);
            validator.SetNext(new TherapistAvailabilityValidator(TherapistUnavailable, ref errorCodes));
            validator.Validate(new TherapySession()
            {
                Patient = _patientService.GetById(patient.Id),
                Therapist = (Therapist) UserService.Instance.GetUserById(UserService.Instance.LoggedInUserId),
                DateTime = sessionDate.Date.Add(sessionTime.TimeOfDay), EstimatedDuration = estimatedDuration
            });
            validator = new EnumerableEmptyValidator(AtLeastOneTreatment, ref errorCodes);
            validator.Validate(treatments);

            return errorCodes;
        }

        public void CreateTherapySession(PatientDTO patient, DateTime sessionDate, DateTime sessionTime,
            IEnumerable<TreatmentDTO> treatments, TimeSpan estimatedDuration)
        {
            TherapySessionService.Instance.AddTherapySession(_patientService.GetById(patient.Id),
                sessionDate.Date.Add(sessionTime.TimeOfDay),
                treatments.Select(e => PrescriptionItemService.Instance.GetTreatmentById(e.Id)), estimatedDuration);
        }

        public IEnumerable<TherapySessionDTO> GetPastTherapySessionsOfLoggedInTherapist()
        {
            return _therapySessionService.GetTherapySessionsBeforeDate(
                _therapySessionService.GetAllTherapySessionsOfTherapist(UserService.Instance.LoggedInUserId),
                new DateTime(2022, 1, 1)).Select(e => TherapySessionDTO.ConvertTherapySessionToDTO(e));
        }

        public void SelectTherapySession(TherapySessionDTO session)
        {
            _therapySessionService.SelectedTherapySessionId = session.Id;
        }

        public string GetTreatmentNote(int sessionId, int treatmentId)
        {
            return _therapySessionService
                .GetTherapySessionHasTreatmentsBySessionIdAndTreatmentId(sessionId, treatmentId).Note;
        }

        public bool GetTreatmentCompletedStatus(int sessionId, int treatmentId)
        {
            return _therapySessionService
                .GetTherapySessionHasTreatmentsBySessionIdAndTreatmentId(sessionId, treatmentId)
                .CompletedTreatment;
        }

        public IEnumerable<PrescriptionDTO> GetLoggedInPatientsPrescriptions()
        {
            return _prescriptionService.GetPrescriptionsOfPatientById(_userService.LoggedInUserId)
                .Select(e => PrescriptionDTO.ConvertPrescriptionToDTO(e));
        }

        public IEnumerable<PrescriptionDTO> GetLoggedInPatientsPrescriptionsStartedBeforeDate(DateTime date)
        {
            return _prescriptionService.GetPrescriptionsStartedBeforeDate(
                    _prescriptionService.GetPrescriptionsOfPatientById(_userService.LoggedInUserId), date)
                .Select(e => PrescriptionDTO.ConvertPrescriptionToDTO(e));
        }

        public IEnumerable<TherapySessionDTO> GetLoggedInTherapistsTherapySessionsAtDate(DateTime date)
        {
            return _therapySessionService.GetTherapySessionsAtDate(
                    _therapySessionService.GetAllTherapySessionsOfTherapist(_userService.LoggedInUserId), date)
                .Select(e => TherapySessionDTO.ConvertTherapySessionToDTO(e));
        }

        public IEnumerable<TherapySessionDTO> GetLoggedInPatientsTherapySessionsAtDate(DateTime date)
        {
            return _therapySessionService.GetTherapySessionsAtDate(
                    _therapySessionService.GetAllTherapySessionsOfPatient(_userService.LoggedInUserId), date)
                .Select(e => TherapySessionDTO.ConvertTherapySessionToDTO(e));
        }

        public UserDTO GetUserById(int id)
        {
            return UserDTO.ConvertUserToDTO(_userService.GetUserById(id));
        }

        public IEnumerable<PrescriptionItemDTO> GetPrescriptionItems(int pres_id)
        {
            return _prescriptionService.GetPrescriptionItemsOfPrescriptionById(pres_id)
                .Select(e => PrescriptionItemDTO.ConvertPrescriptionItemToDTO(e));
        }

        public MedicineDTO GetMedicineById(int id)
        {
            return MedicineDTO.ConvertMedicineToDTO(_prescriptionItemService.GetMedicineById(id));
        }

        public ExerciseDTO GetExerciseById(int id)
        {
            return ExerciseDTO.ConvertExerciseToDTO(_prescriptionItemService.GetExerciseById(id));
        }

        public bool IsMedicine(int id)
        {
            return _prescriptionItemService.IsMedicine(id);
        }

        public bool IsExercise(int id)
        {
            return _prescriptionItemService.IsExercise(id);
        }

        public bool IsMedicineByName(string name)
        {
            return _prescriptionItemService.IsMedicineByName(name);
        }

        public bool IsExerciseByName(string name)
        {
            return _prescriptionItemService.IsExerciseByName(name);
        }

        public bool IsTreatmentByName(string name)
        {
            return _prescriptionItemService.IsTreatmentByName(name);
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

        public void SelectPrescriptions(IEnumerable<PrescriptionDTO> prescriptions)
        {
            _prescriptionService.SelectedPrescriptions = new List<Prescription>();
            foreach (var prescription in prescriptions)
            {
                _prescriptionService.AddSelectedPrescriptionById(prescription.Id);
            }
        }

        public IEnumerable<HealthCareProfessionalDTO> GetHealthCareProfessionals()
        {
            return _healthCareProfessionalService.GetAll()
                .Select(e => HealthCareProfessionalDTO.ConvertHealthCareProfessionalToDTO(e));
        }

        public void AddPermissionToHealthCareProfessionals(IEnumerable<HealthCareProfessionalDTO> professionals)
        {
            foreach (var prescription in _prescriptionService.SelectedPrescriptions)
            {
                foreach (var professional in professionals)
                {
                    _prescriptionService.AddHealthCareProfessionalAsViewerToPrescription(
                        _prescriptionService.GetPrescriptionById(prescription.Id),
                        _healthCareProfessionalService.GetById(professional.Id));
                }
            }
        }

        public IEnumerable<PrescriptionHasPrescriptionItems> GetPrescriptionHasItemsEnumerableByPrescriptionId(
            int prescriptionId)
        {
            return _prescriptionService.GetPrescriptionHasItemsEnumerableByPrescriptionId(prescriptionId);
        }

        public TherapySessionDTO GetSelectedTherapySession()
        {
            return TherapySessionDTO.ConvertTherapySessionToDTO(_therapySessionService.GetSelectedTherapySession());
        }

        public BodyPart ConvertStringToBodyPart(string bodyPart)
        {
            return (BodyPart) Enum.Parse(typeof(BodyPart), bodyPart);
        }
    }
}