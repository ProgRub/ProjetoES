using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ComponentsLibrary;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Repositories.Implementations;
using ComponentsLibrary.Repositories.Interfaces;

namespace ServicesLibrary.DifferentServices
{
    public class UserService
    {
        private IUserRepository _userRepository;

        internal int LoggedInUserId { get; private set; }

        private UserService()
        {
            _userRepository = new UserRepository(Database.GetContext());
        }

        internal static UserService Instance { get; } = new UserService();

        internal User GetUserById(int id)
        {
            return _userRepository.Find(e => e.Id == id).First();
        }

        internal bool IsHealthUserNumberUnique(int healthUserNumber)
        {
            return !_userRepository.Find(e => e.HealthUserNumber == healthUserNumber).Any();
        }

        internal bool IsEmailUnique(string email)
        {
            return !_userRepository.Find(e => e.Email == email).Any();
        }

        internal bool IsTherapistOldEnough(DateTime dateOfBirth)
        {
            return (DateTime.Today - dateOfBirth).Days >= 22 * 365.75;
        }

        internal void RegisterUser(string name, DateTime dateOfBirth, int phoneNumber, int healthUserNumber,
            string email, string password, IEnumerable<string> allergies, IEnumerable<string> diseases,
            IEnumerable<string> missingBodyParts, string type)
        {
            switch (type)
            {
                case "Patient":
                    var patient = new Patient
                    {
                        FullName = name, DateOfBirth = dateOfBirth, Email = email, HealthUserNumber = healthUserNumber,
                        Password = password, PhoneNumber = phoneNumber
                    };
                    _userRepository.AddPatient(patient);
                    AddMedicalConditionsToUser(patient, allergies, diseases);
                    AddMissingBodyPartsToUser(patient, missingBodyParts);
                    _userRepository.SaveChanges();
                    return;
                case "Therapist":
                    var therapist = new Therapist
                    {
                        FullName = name, DateOfBirth = dateOfBirth, Email = email, HealthUserNumber = healthUserNumber,
                        Password = password, PhoneNumber = phoneNumber
                    };
                    _userRepository.AddTherapist(therapist);
                    AddMedicalConditionsToUser(therapist, allergies, diseases);
                    AddMissingBodyPartsToUser(therapist, missingBodyParts);
                    _userRepository.SaveChanges();
                    return;
            }
        }

        private void AddMedicalConditionsToUser(User user, IEnumerable<string> allergies, IEnumerable<string> diseases)
        {
            foreach (var allergyString in allergies)
            {
                _userRepository.AddMedicalConditionToUser(user,
                    MedicalConditionService.Instance.GetMedicalConditionByName(allergyString));
            }

            foreach (var diseaseString in diseases)
            {
                _userRepository.AddMedicalConditionToUser(user,
                    MedicalConditionService.Instance.GetMedicalConditionByName(diseaseString));
            }
        }

        private void AddMissingBodyPartsToUser(User user, IEnumerable<string> missingBodyParts)
        {
            foreach (var bodyPartString in missingBodyParts)
            {
                _userRepository.AddMissingBodyPartToUser(user, (BodyPart) Enum.Parse(typeof(BodyPart), bodyPartString));
            }
        }

        internal bool IsUserEmailInDatabase(string email)
        {
            return _userRepository.Find(e => e.Email == email).Any();
        }

        internal bool DoesPasswordCorrespondToEmail(string email, string password)
        {
            return _userRepository.Find(e => e.Email == email && e.Password == password).Any();
        }

        internal int LogIn(string email, string password)
        {
            var user = _userRepository.Find(e => e.Email == email && e.Password == password).First();
            LoggedInUserId = user.Id;
            if (_userRepository.GetAllPatients().Contains(user))
            {
                return Services.Patient;
            }

            return Services.Therapist;
        }

        internal void LoadDBHelpFunction()
        {
            _userRepository.GetAll();
        }

        internal IEnumerable<Patient> GetAllPatients()
        {
            return _userRepository.GetAllPatients();
        }

        internal bool IsPatientAvailable(int patientId, DateTime sessionDate, DateTime sessionHour, TimeSpan estimatedDuration)
        {
            return false;
        }

        internal bool IsTherapistAvailable(DateTime sessionDate, DateTime sessionHour, TimeSpan estimatedDuration)
        {
            return false;
        }

        public IEnumerable<HealthCareProfessional> GetAllHealthCareProfessionals()
        {
            return _userRepository.GetAllHealthCareProfessionals();
        }
    }
}