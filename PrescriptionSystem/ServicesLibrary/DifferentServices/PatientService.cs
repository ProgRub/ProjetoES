using System.Collections.Generic;
using ComponentsLibrary;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Repositories.Implementations;
using ComponentsLibrary.Repositories.Interfaces;
using ServicesLibrary.DTOs;

namespace ServicesLibrary.DifferentServices
{
    public class PatientService : UserService
    {
        private readonly IPatientRepository _patientRepository;

        private PatientService()
        {
            _patientRepository = new PatientRepository(Database.GetContext());
        }

        internal new static PatientService Instance { get; } = new PatientService();
        internal int SelectedPatientId { get; set; }

        public Patient GetById(int id)
        {
            return _patientRepository.GetById(id);
        }

        internal IEnumerable<Patient> GetAll()
        {
            return _patientRepository.GetAll();
        }

        internal void RegisterPatient(UserDTO user, string email, string password)
        {
            var patient = new Patient
            {
                FullName = user.FullName, DateOfBirth = user.DateOfBirth, Email = email, Password = password,
                HealthUserNumber = user.HealthUserNumber, PhoneNumber = user.PhoneNumber
            };
            _patientRepository.Add(patient);
            AddMedicalConditionsToUser(patient, user.Allergies, user.Diseases);
            AddMissingBodyPartsToUser(patient, user.MissingBodyParts);
            _patientRepository.SaveChanges();
            UserService.Instance.SaveChanges();
        }
    }
}