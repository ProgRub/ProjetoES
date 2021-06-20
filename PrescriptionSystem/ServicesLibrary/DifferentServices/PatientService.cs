using System;
using System.Collections.Generic;
using ComponentsLibrary;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Repositories.Implementations;
using ComponentsLibrary.Repositories.Interfaces;

namespace ServicesLibrary.DifferentServices
{
    public class PatientService : UserService
    {
        private IPatientRepository _patientRepository;

        private PatientService()
        {
            _patientRepository = new PatientRepository(Database.GetContext());
        }

        internal new static PatientService Instance { get; } = new PatientService();

        internal void RegisterPatient(string name, DateTime dateOfBirth, int phoneNumber, int healthUserNumber,
            string email,
            string password, IEnumerable<string> allergies, IEnumerable<string> diseases,
            IEnumerable<string> missingBodyParts)
        {
            var patient = new Patient
            {
                FullName = name,
                DateOfBirth = dateOfBirth,
                Email = email,
                HealthUserNumber = healthUserNumber,
                Password = password,
                PhoneNumber = phoneNumber
            };
            _patientRepository.Add(patient);
            AddMedicalConditionsToUser(patient, allergies, diseases);
            AddMissingBodyPartsToUser(patient, missingBodyParts);
            _patientRepository.SaveChanges();
            Services.Instance.SaveChanges();
        }

        public Patient GetById(int id)
        {
            return _patientRepository.GetById(id);
        }

        internal IEnumerable<Patient> GetAll()
        {
            return _patientRepository.GetAll();
        }
    }
}