using System.Collections.Generic;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Repositories.Interfaces;

namespace ComponentsLibrary.Repositories.Implementations
{
    public class UserRepository:BaseRepository<User>,IUserRepository
    {
        private UserHasMissingBodyPartRepository _userHasMissingBodyPartRepository;
        private IPatientRepository _patientRepository;
        private ITherapistRepository _therapistRepository;
        private IHealthCareProfessionalRepository _healthCareProfessionalRepository;

        public UserRepository(PrescriptionSystemDbContext context) : base(context)
        {
            _userHasMissingBodyPartRepository = new UserHasMissingBodyPartRepository(context);
            _patientRepository = new PatientRepository(context);
            _therapistRepository = new TherapistRepository(context);
            _healthCareProfessionalRepository = new HealthCareProfessionalRepository(context);
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

        public IEnumerable<HealthCareProfessional> GetAllHealthCareProfessionals()
        {
            return _healthCareProfessionalRepository.GetAll();
        }
    }
}