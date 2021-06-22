using System.Collections.Generic;
using System.Linq;
using ComponentsLibrary;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Repositories.Implementations;
using ComponentsLibrary.Repositories.Interfaces;
using ServicesLibrary.DTOs;

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
            return _userRepository.GetById(id);
        }

        //internal void RegisterUser(string name, DateTime dateOfBirth, int phoneNumber, int healthUserNumber,
        //    string email, string password, IEnumerable<MedicalConditionDTO> allergies, IEnumerable<MedicalConditionDTO> diseases,
        //    IEnumerable<string> missingBodyParts, string userType)
        //{
        //    switch (userType)
        //    {
        //        case "Patient":
        //            PatientService.Instance.RegisterPatient(name, dateOfBirth, phoneNumber, healthUserNumber, email, password, allergies, diseases, missingBodyParts);
        //            return;
        //        case "Therapist":
        //            TherapistService.Instance.RegisterTherapist(name, dateOfBirth, phoneNumber, healthUserNumber, email, password, allergies, diseases, missingBodyParts);
        //            return;
        //    }
        //}
        public void RegisterUser(UserDTO user, string email, string password, string userType)
        {
            switch (userType)
            {
                case "Patient":
                    PatientService.Instance.RegisterPatient(user,email,password);
                    return;
                case "Therapist":
                    TherapistService.Instance.RegisterTherapist(user, email, password);
                    return;
            }
        }

        protected void AddMedicalConditionsToUser(User user, IEnumerable<MedicalConditionDTO> allergies, IEnumerable<MedicalConditionDTO> diseases)
        {
            foreach (var allergy in allergies)
            {
                _userRepository.AddMedicalConditionToUser(user,
                    MedicalConditionService.Instance.GetMedicalConditionById(allergy.Id));
            }

            foreach (var disease in diseases)
            {
                _userRepository.AddMedicalConditionToUser(user,
                    MedicalConditionService.Instance.GetMedicalConditionById(disease.Id));
            }
        }

        //protected void AddMissingBodyPartsToUser(User user, IEnumerable<string> missingBodyParts)
        //{
        //    foreach (var bodyPartString in missingBodyParts)
        //    {
        //        _userRepository.AddMissingBodyPartToUser(user, (BodyPart) Enum.Parse(typeof(BodyPart), bodyPartString));
        //    }
        //}

        protected void AddMissingBodyPartsToUser(User user, IEnumerable<BodyPart> missingBodyParts)
        {
            user.MissingBodyParts = missingBodyParts.ToList();
            //foreach (var bodyPart in missingBodyParts)
            //{
            //    _userRepository.AddMissingBodyPartToUser(user, bodyPart);
            //}
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
            return _userRepository.GetById(id).MissingBodyParts;
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