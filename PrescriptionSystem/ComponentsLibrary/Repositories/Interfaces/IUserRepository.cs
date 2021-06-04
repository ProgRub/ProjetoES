using System.Collections.Generic;
using ComponentsLibrary.Entities;

namespace ComponentsLibrary.Repositories.Interfaces
{
    public interface IUserRepository:IGenericRepository<User>
    {
        void AddPatient(Patient patient);
        void AddTherapist(Therapist therapist);
        void AddMedicalConditionToUser(User user, MedicalCondition medicalCondition);
        void AddMissingBodyPartToUser(User user, BodyPart bodyPart);
        IEnumerable<Patient> GetAllPatients();
        IEnumerable<Therapist> GetAllTherapists();
    }
}