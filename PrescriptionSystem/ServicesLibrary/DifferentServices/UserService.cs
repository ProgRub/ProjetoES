using System;
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

        public UserService()
        {
            _userRepository = new UserRepository(Database.GetContext());
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
            Debug.WriteLine(DateTime.Today.Date);
            Debug.WriteLine(dateOfBirth.Date);
            Debug.WriteLine((DateTime.Today.Date - dateOfBirth.Date).TotalDays);
            Debug.WriteLine(( dateOfBirth.Date-DateTime.Today.Date).TotalDays);
            Debug.WriteLine(22 * 365.75);
            return (DateTime.Today - dateOfBirth).Days >= 22 * 365.75;
        }

        internal void RegisterUser(string name, DateTime dateOfBirth, int phoneNumber, int healthUserNumber,
            string email, string password, IEnumerable<string> allergies, IEnumerable<string> diseases,
            IEnumerable<string> missingBodyParts, string type)
        {
            switch (type)
            {
                case "Patient":
                    Patient patient = new Patient
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
                    Therapist therapist = new Therapist
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
                    Services.Instance.GetMedicalConditionByName(allergyString));
            }

            foreach (var diseaseString in diseases)
            {
                Debug.WriteLine(Services.Instance.GetMedicalConditionByName(diseaseString).Name);
                _userRepository.AddMedicalConditionToUser(user,
                    Services.Instance.GetMedicalConditionByName(diseaseString));
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

        internal int GetLoggedInUserType(string email, string password)
        {
            User user = _userRepository.Find(e => e.Email == email && e.Password == password).First();
            Services.Instance.LoggedInUserID = user.Id;
            Debug.WriteLine(Services.Instance.LoggedInUserID);
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
    }
}