using System;
using System.Collections.Generic;
using ComponentsLibrary;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Repositories.Implementations;
using ComponentsLibrary.Repositories.Interfaces;
using ServicesLibrary.DTOs;

namespace ServicesLibrary.DifferentServices
{
    public class TherapistService:UserService
    {
        private ITherapistRepository _therapistRepository;

        private TherapistService()
        {
            _therapistRepository = new TherapistRepository(Database.GetContext());
        }

        internal new static TherapistService Instance { get; } = new TherapistService();



        internal void RegisterTherapist(string name, DateTime dateOfBirth, int phoneNumber, int healthUserNumber, string email,
            string password, IEnumerable<MedicalConditionDTO> allergies, IEnumerable<MedicalConditionDTO> diseases, IEnumerable<string> missingBodyParts)
        {
            var therapist = new Therapist
            {
                FullName = name,
                DateOfBirth = dateOfBirth,
                Email = email,
                HealthUserNumber = healthUserNumber,
                Password = password,
                PhoneNumber = phoneNumber
            };
            _therapistRepository.Add(therapist);
            AddMedicalConditionsToUser(therapist, allergies, diseases);
            AddMissingBodyPartsToUser(therapist, missingBodyParts);
            _therapistRepository.SaveChanges();
            Services.Instance.SaveChanges();
        }
    }
}