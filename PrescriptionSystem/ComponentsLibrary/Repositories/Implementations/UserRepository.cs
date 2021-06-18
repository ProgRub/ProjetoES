using System.Collections.Generic;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Repositories.Interfaces;

namespace ComponentsLibrary.Repositories.Implementations
{
    public class UserRepository:BaseRepository<User>,IUserRepository
    {
        private UserHasMedicalConditionRepository _userHasMedicalConditionRepository;
        private UserHasMissingBodyPartRepository _userHasMissingBodyPartRepository;
        private PatientRepository _patientRepository;
        private TherapistRepository _therapistRepository;

        public UserRepository(PrescriptionSystemDbContext context) : base(context)
        {
            _userHasMedicalConditionRepository = new UserHasMedicalConditionRepository(context);
            _userHasMissingBodyPartRepository = new UserHasMissingBodyPartRepository(context);
            _patientRepository = new PatientRepository(context);
            _therapistRepository = new TherapistRepository(context);
        }

        public void AddPatient(Patient patient)
        {
            _patientRepository.Add(patient);
        }

        public void AddTherapist(Therapist therapist)
        {
            _therapistRepository.Add(therapist);
        }

        public void AddMedicalConditionToUser(User user, MedicalCondition medicalCondition)
        {
            if (user.UserHasMedicalConditions == null)
            {
                user.UserHasMedicalConditions = new List<UserHasMedicalCondition>
                {
                    new UserHasMedicalCondition
                    {
                        User = user, MedicalCondition = medicalCondition
                    }
                };
            }
            else
            {
                user.UserHasMedicalConditions.Add(new UserHasMedicalCondition
                {
                    User = user,
                    MedicalCondition = medicalCondition
                });
            }
        }

        public void AddMissingBodyPartToUser(User user, BodyPart bodyPart)
        {
            _userHasMissingBodyPartRepository.Add(new UserHasMissingBodyPart
            {
                User = user,BodyPart = bodyPart
            });
        }

        public IEnumerable<Patient> GetAllPatients()
        {
            return _patientRepository.GetAll();
        }

        public IEnumerable<Therapist> GetAllTherapists()
        {
            return _therapistRepository.GetAll();
        }

        public IEnumerable<UserHasMissingBodyPart> GetAllMissingBodyParts()
        {
            return _userHasMissingBodyPartRepository.GetAll();
        }

    }
}