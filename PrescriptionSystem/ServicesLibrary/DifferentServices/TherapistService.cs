using ComponentsLibrary;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Repositories.Implementations;
using ComponentsLibrary.Repositories.Interfaces;
using ServicesLibrary.DTOs;

namespace ServicesLibrary.DifferentServices
{
    public class TherapistService : UserService
    {
        private readonly ITherapistRepository _therapistRepository;

        private TherapistService()
        {
            _therapistRepository = new TherapistRepository(Database.GetContext());
        }

        internal new static TherapistService Instance { get; } = new TherapistService();

        internal void RegisterTherapist(UserDTO user, string email, string password)
        {
            var therapist = new Therapist
            {
                FullName = user.FullName,
                DateOfBirth = user.DateOfBirth,
                Email = email,
                Password = password,
                HealthUserNumber = user.HealthUserNumber,
                PhoneNumber = user.PhoneNumber
            };
            _therapistRepository.Add(therapist);
            AddMedicalConditionsToUser(therapist, user.Allergies, user.Diseases);
            AddMissingBodyPartsToUser(therapist, user.MissingBodyParts);
            _therapistRepository.SaveChanges();
            UserService.Instance.SaveChanges();
        }
    }
}