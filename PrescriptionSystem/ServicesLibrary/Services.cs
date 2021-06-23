using System;
using System.Collections.Generic;
using System.Linq;
using ComponentsLibrary.Entities;
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
            TherapistNotOldEnough = 14;

        #endregion

        #region PrescriptionItemCreation

        public const int DescriptionRequired = 15,
            AgeMinimumNotANumber = 16,
            AgeMaximumNotANumber = 17,
            PriceNotValid = 18,
            AgesNotValid = 19,
            DatesNotValid = 20,
            ItemAlreadyExists = 21,
            AgeMinimumRequired = 22,
            AgeMaximumRequired = 23,
            AtLeastOneBodyPart = 24,
            DurationNotValid = 25;

        #endregion

        #region LoggingIn

        public const int EmailDoesntExist = 1, PasswordDoesntMatch = 2;

        #endregion

        #region TherapySessionCreation

        public const int PatientUnavailable = 1, TherapistUnavailable = 2, PatientRequired = 3, AtLeastOneTreatment = 4;

        #endregion

        #region PrescriptionCreation

        public const int InvalidAge = 15,
            IncompatibleMedicine = 16,
            IncompatibleDisease = 17,
            MissingBodyPart = 18,
            AtLeastOnePrescriptionItem = 19;

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

        #region Checkers

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

        public IEnumerable<int> CheckPrescriptionCreation(PrescriptionDTO prescription)
        {
            var errorCodes = new List<int>();
            BaseValidator validator = new ObjectNotNullValidator(PatientRequired, ref errorCodes);
            validator.Validate(prescription.Patient);
            if (errorCodes.Any()) return errorCodes;
            validator = new AgeValidator(InvalidAge, ref errorCodes);
            validator.SetNext(new AllergyValidator(IncompatibleMedicine, ref errorCodes))
                .SetNext(new ExistingDiseaseValidator(IncompatibleDisease, ref errorCodes))
                .SetNext(new MissingBodyPartValidator(MissingBodyPart, ref errorCodes))
                .SetNext(new StartDateIsBeforeEndDateValidator(DatesNotValid, ref errorCodes));
            validator.Validate(prescription);
            validator = new EnumerableNotEmptyValidator(AtLeastOnePrescriptionItem, ref errorCodes);
            validator.Validate(prescription.PrescriptionItemsRecommendedTimes.Keys);

            return errorCodes;
        }

        public IEnumerable<int> CheckExerciseOrTreatmentCreation(string name, string ageMinimum,
            string ageMaximum, TimeSpan duration, IEnumerable<BodyPart> bodyParts, string type)
        {
            var errorCodes = new List<int>();
            BaseValidator validator = new StringEmptyValidator(NameRequired, ref errorCodes);
            validator.Validate(name);
            validator = new StringEmptyValidator(AgeMinimumRequired, ref errorCodes);
            validator.SetNext(new StringIsIntegerValidator(AgeMinimumNotANumber, ref errorCodes));
            validator.Validate(ageMinimum);
            validator = new StringEmptyValidator(AgeMaximumRequired, ref errorCodes);
            validator.SetNext(new StringIsIntegerValidator(AgeMaximumNotANumber, ref errorCodes));
            validator.Validate(ageMaximum);
            if (errorCodes.Any()) return errorCodes;
            validator = new MaxAgeGreaterThanMinAgeValidator(AgesNotValid, ref errorCodes);
            validator.Validate(new Tuple<int, int>(int.Parse(ageMaximum), int.Parse(ageMinimum)));
            validator = new EnumerableNotEmptyValidator(AtLeastOneBodyPart, ref errorCodes);
            validator.Validate(bodyParts);
            validator = new DurationGreaterThanZeroValidator(DurationNotValid, ref errorCodes);
            validator.Validate(duration);

            if (errorCodes.Any()) return errorCodes;
            validator = new PrescriptionItemUniqueValidator(ItemAlreadyExists, ref errorCodes);
            switch (type)
            {
                case "Exercise":
                    validator.Validate(new ExerciseDTO
                    {
                        Name = name, Duration = duration, BodyParts = bodyParts
                    });
                    break;
                case "Treatment":
                    validator.Validate(new TreatmentDTO
                    {
                        Name = name,
                        Duration = duration,
                        BodyPart = bodyParts.First()
                    });
                    break;
                default:
                    throw new NotImplementedException();
            }

            return errorCodes;
        }

        public IEnumerable<int> CheckMedicineCreation(string name, string price)
        {
            var errorCodes = new List<int>();
            BaseValidator validator = new StringEmptyValidator(NameRequired, ref errorCodes);
            validator.Validate(name);
            validator = new StringEmptyValidator(PriceNotValid, ref errorCodes);
            validator.SetNext(new StringIsDoubleValidator(PriceNotValid, ref errorCodes));
            validator.Validate(price);
            if (errorCodes.Any()) return errorCodes;
            validator = new PrescriptionItemUniqueValidator(ItemAlreadyExists, ref errorCodes);
            validator.Validate(new MedicineDTO()
            {
                Name = name,
                Price = double.Parse(price)
            });
            return errorCodes;
        }


        public IEnumerable<int> CheckTherapySessionCreation(TherapySessionDTO session)
        {
            var errorCodes = new List<int>();

            BaseValidator validator = new ObjectNotNullValidator(PatientRequired, ref errorCodes);
            validator.Validate(session.Patient);
            if (errorCodes.Any()) return errorCodes;
            validator = new EnumerableNotEmptyValidator(AtLeastOneTreatment, ref errorCodes);
            validator.Validate(session.Treatments);
            if (errorCodes.Any()) return errorCodes;

            validator = new PatientAvailabilityValidator(PatientUnavailable, ref errorCodes);
            validator.SetNext(new TherapistAvailabilityValidator(TherapistUnavailable, ref errorCodes))
                .SetNext(new AgeValidator(InvalidAge, ref errorCodes))
                .SetNext(new MissingBodyPartValidator(MissingBodyPart, ref errorCodes));
            validator.Validate(session);

            return errorCodes;
        }

        #endregion

        #region Adders

        public void RegisterUser(UserDTO user, string email, string password, string userType) =>
            _userService.RegisterUser(user, email, password, userType);

        public void CreatePrescription(PrescriptionDTO prescription) =>
            _prescriptionService.CreatePrescription(prescription);

        public void CreateExercisePrescriptionItem(ExerciseDTO exercise) =>
            _prescriptionItemService.CreateExercisePrescriptionItem(exercise);

        public void CreateMedicinePrescriptionItem(MedicineDTO medicine) =>
            _prescriptionItemService.CreateMedicinePrescriptionItem(medicine);

        public void CreateTreatmentPrescriptionItem(TreatmentDTO treatment) =>
            _prescriptionItemService.CreateTreatmentPrescriptionItem(treatment);

        public void CreateTherapySession(TherapySessionDTO therapySession) =>
            _therapySessionService.AddTherapySession(therapySession);

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

        #endregion

        #region Getters

        public IEnumerable<MedicalConditionDTO> GetAllAllergies() => _medicalConditionService.GetAllergies()
            .Select(e => MedicalConditionDTO.ConvertMedicalConditionToDTO(e));

        public IEnumerable<ExerciseDTO> GetAllExercises() => _prescriptionItemService.GetAllExercises()
            .Select(e => ExerciseDTO.ConvertExerciseToDTO(e));

        public IEnumerable<MedicineDTO> GetAllMedicines() => _prescriptionItemService.GetAllMedicine()
            .Select(e => MedicineDTO.ConvertMedicineToDTO(e));

        public IEnumerable<MedicalConditionDTO> GetAllDiseases() => _medicalConditionService.GetDiseases()
            .Select(e => MedicalConditionDTO.ConvertMedicalConditionToDTO(e));

        public IEnumerable<PatientDTO> GetAllPatients() =>
            _patientService.GetAll().Select(e => PatientDTO.ConvertPatientToDTO(e));

        public IEnumerable<TreatmentDTO> GetAllTreatments() => _prescriptionItemService.GetAllTreatments()
            .Select(e => TreatmentDTO.ConvertTreatmentToDTO(e));

        public IEnumerable<TherapySessionDTO> GetPastTherapySessionsOfLoggedInTherapist() => _therapySessionService
            .GetTherapySessionsBeforeDate(
                _therapySessionService.GetAllTherapySessionsOfTherapist(UserService.Instance.LoggedInUserId),
                new DateTime(2022, 1, 1)).Select(e => TherapySessionDTO.ConvertTherapySessionToDTO(e));

        public string GetTreatmentNote(int sessionId, int treatmentId) => _therapySessionService
            .GetTherapySessionHasTreatmentsBySessionIdAndTreatmentId(sessionId, treatmentId).Note;

        public bool GetTreatmentCompletedStatus(int sessionId, int treatmentId) => _therapySessionService
            .GetTherapySessionHasTreatmentsBySessionIdAndTreatmentId(sessionId, treatmentId)
            .CompletedTreatment;

        public IEnumerable<PrescriptionDTO> GetAllLoggedInPatientsPrescriptions() => _prescriptionService
            .GetPrescriptionsOfPatientById(_userService.LoggedInUserId)
            .Select(e => PrescriptionDTO.ConvertPrescriptionToDTO(e));

        public IEnumerable<PrescriptionDTO> GetLoggedInPatientsPrescriptionsStartedBeforeDate(DateTime date) =>
            _prescriptionService.GetPrescriptionsStartedBeforeDate(
                    _prescriptionService.GetPrescriptionsOfPatientById(_userService.LoggedInUserId), date)
                .Select(e => PrescriptionDTO.ConvertPrescriptionToDTO(e));

        public IEnumerable<TherapySessionDTO> GetLoggedInTherapistsTherapySessionsAtDate(DateTime date) =>
            _therapySessionService.GetTherapySessionsAtDate(
                    _therapySessionService.GetAllTherapySessionsOfTherapist(_userService.LoggedInUserId), date)
                .Select(e => TherapySessionDTO.ConvertTherapySessionToDTO(e));

        public IEnumerable<TherapySessionDTO> GetLoggedInPatientsTherapySessionsAtDate(DateTime date) =>
            _therapySessionService.GetTherapySessionsAtDate(
                    _therapySessionService.GetAllTherapySessionsOfPatient(_userService.LoggedInUserId), date)
                .Select(e => TherapySessionDTO.ConvertTherapySessionToDTO(e));

        public IEnumerable<HealthCareProfessionalDTO> GetAllHealthCareProfessionals() => _healthCareProfessionalService
            .GetAll()
            .Select(e => HealthCareProfessionalDTO.ConvertHealthCareProfessionalToDTO(e));

        public TherapySessionDTO GetSelectedTherapySession() =>
            TherapySessionDTO.ConvertTherapySessionToDTO(_therapySessionService.GetSelectedTherapySession());

        public HealthCareProfessionalDTO GetLoggedInHealthCareProfessional() =>
            HealthCareProfessionalDTO.ConvertHealthCareProfessionalToDTO(
                (HealthCareProfessional) _userService.GetUserById(_userService.LoggedInUserId));

        public TherapistDTO GetLoggedInTherapist() =>
            TherapistDTO.ConvertTherapistToDTO((Therapist) _userService.GetUserById(_userService.LoggedInUserId));

        public PrescriptionDTO GetSelectedPrescription() =>
            PrescriptionDTO.ConvertPrescriptionToDTO(_prescriptionService.SelectedPrescriptions[0]);

        public PatientDTO GetSelectedPatient() =>
            PatientDTO.ConvertPatientToDTO(_patientService.GetById(_patientService.SelectedPatientId));

        public IEnumerable<PrescriptionDTO> GetPatientsPrescriptionsByPatientId(int id) => _prescriptionService
            .GetPrescriptionsOfPatientById(id).Select(e => PrescriptionDTO.ConvertPrescriptionToDTO(e));

        #endregion

        #region Selectors

        public void SelectTherapySession(TherapySessionDTO session) =>
            _therapySessionService.SelectedTherapySessionId = session.Id;

        public void SelectPrescriptions(IEnumerable<PrescriptionDTO> prescriptions)
        {
            _prescriptionService.SelectedPrescriptions = new List<Prescription>();
            foreach (var prescription in prescriptions)
            {
                _prescriptionService.AddSelectedPrescriptionById(prescription.Id);
            }
        }

        public void SelectPatient(PatientDTO patient)
        {
            _patientService.SelectedPatientId = patient.Id;
        }

        #endregion

        #region Others

        public int Login(string email, string password)
        {
            if (!_userService.IsUserEmailInDatabase(email)) return EmailDoesntExist;
            if (!_userService.DoesPasswordCorrespondToEmail(email, password)) return PasswordDoesntMatch;
            return _userService.LogIn(email, password);
        }

        public void LoadDatabase() => _userService.LoadDBHelpFunction();

        public bool IsMedicine(int id) => _prescriptionItemService.IsMedicine(id);
        public bool IsExercise(int id) => _prescriptionItemService.IsExercise(id);

        public bool CanHealthCareProfessionalViewPrescription(PrescriptionDTO prescription,
            HealthCareProfessionalDTO healthCareProfessional) =>
            _prescriptionService.CanHealthCareProfessionalViewPrescription(
                _prescriptionService.GetPrescriptionById(prescription.Id),
                _healthCareProfessionalService.GetById(healthCareProfessional.Id));

        public BodyPart ConvertStringToBodyPart(string bodyPart) => (BodyPart) Enum.Parse(typeof(BodyPart), bodyPart);

        #endregion
    }
}