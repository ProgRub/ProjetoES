using System;
using System.Collections.Generic;
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

        public bool IsHealthUserNumberUnique(int healthUserNumber)
        {
            return !_userRepository.Find(e => e.HealthUserNumber == healthUserNumber).Any();
        }

        public bool IsEmailUnique(string email)
        {
            return !_userRepository.Find(e => e.Email == email).Any();
        }

        public bool IsTherapistOldEnough(DateTime dateOfBirth)
        {
            return (DateTime.Today - dateOfBirth).Days >= 22 * 365.75;
        }

        public void RegisterUser(string name, DateTime dateOfBirth, int phoneNumber, int healthUserNumber,
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
    }
}