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

        internal UserService()
        {
            _userRepository = new UserRepository(Database.GetContext());
        }

        internal static UserService Instance { get; } = new UserService();

        internal User GetUserById(int id)
        {
            return _userRepository.Find(e => e.Id == id).First();
        }

        internal void RegisterUser(string name, DateTime dateOfBirth, int phoneNumber, int healthUserNumber,
            string email, string password, IEnumerable<string> allergies, IEnumerable<string> diseases,
            IEnumerable<string> missingBodyParts, string type)
        {
            switch (type)
            {
                case "Patient":
                    PatientService.Instance.RegisterPatient(name, dateOfBirth, phoneNumber, healthUserNumber, email, password, allergies, diseases, missingBodyParts);
                    return;
                case "Therapist":
                    TherapistService.Instance.RegisterTherapist(name, dateOfBirth, phoneNumber, healthUserNumber, email, password, allergies, diseases, missingBodyParts);
                    return;
            }
        }

        protected void AddMedicalConditionsToUser(User user, IEnumerable<string> allergies, IEnumerable<string> diseases)
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

        protected void AddMissingBodyPartsToUser(User user, IEnumerable<string> missingBodyParts)
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
            return PatientService.Instance.GetById(LoggedInUserId)!=null ? Services.Patient : Services.Therapist;
        }

        internal void LoadDBHelpFunction()
        {
            _userRepository.GetAll();
        }

        internal IEnumerable<BodyPart> GetUserMissingBodyPartsByUserId(int id)
        {
            return _userRepository.GetUserHasMissingBodyPartEnumerableByUserId(id).Select(userHasMissingBodyPart => userHasMissingBodyPart.BodyPart).ToList();
        }
        
        internal IEnumerable<MedicalCondition> GetUsersMedicalConditionsByUserId(int userId)
        {
            return _userRepository.GetUserHasMedicalConditionsEnumerableByUserId(userId).Select(userHasMedicalCondition => MedicalConditionService.Instance.GetMedicalConditionById(userHasMedicalCondition.MedicalConditionId)).ToList();
        }

        internal IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAll();
        }

        internal void SaveChanges() => _userRepository.SaveChanges();
    }
}