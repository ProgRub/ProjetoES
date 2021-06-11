using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ComponentsLibrary;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using ComponentsLibrary.Repositories;
using ComponentsLibrary.Repositories.Implementations;
using ComponentsLibrary.Repositories.Interfaces;

namespace ServicesLibrary.DifferentServices
{
    public class TherapySessionService
    {
        private ITherapySessionRepository _therapySessionRepository;

        private TherapySessionService()
        {
            _therapySessionRepository = new TherapySessionRepository(Database.GetContext());
        }

        internal static TherapySessionService Instance { get; } = new TherapySessionService();

        internal IEnumerable<TherapySession> GetAllTherapySessionsOfPatient(Patient patient)
        {
            return _therapySessionRepository.Find(e => e.Patient == patient);
        }

        internal IEnumerable<TherapySession> GetAllTherapySessionsOfTherapist(Therapist therapist)
        {
            return _therapySessionRepository.Find(e => e.Therapist == therapist);
        }

        internal IEnumerable<TherapySession> GetAllTherapySessionsOfTherapist(int therapistId)
        {
            return _therapySessionRepository.Find(e => e.TherapistId == therapistId);
        }

        internal void AddTherapySession(Patient patient, DateTime sessionDateTime,
            IEnumerable<Treatment> treatments, TimeSpan estimatedDuration)
        {
            throw new NotImplementedException();
            var therapySession = new TherapySession
            {
                PatientId = patient.Id,
                TherapistId = ((Therapist) UserService.Instance.GetUserById(UserService.Instance.LoggedInUserId)).Id,
                DateTime = sessionDateTime,
                EstimatedDuration = estimatedDuration
            };
            _therapySessionRepository.Add(therapySession);
            foreach (var treatment in treatments)
            {
                _therapySessionRepository.AddTreatmentToTherapySession(therapySession,treatment);
            }
            _therapySessionRepository.SaveChanges();
        }

        internal IEnumerable<TherapySession> GetTherapySessionsBeforeDate(IEnumerable<TherapySession> therapySessions,
            DateTime date)
        {
            return therapySessions.Where(e => e.DateTime < date);
        }
    }
}