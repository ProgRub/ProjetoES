using System;
using System.Collections.Generic;
using System.Linq;
using ComponentsLibrary;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using ComponentsLibrary.Repositories.Implementations;
using ComponentsLibrary.Repositories.Interfaces;
using ServicesLibrary.DTOs;

namespace ServicesLibrary.DifferentServices
{
    public class TherapySessionService
    {
        private readonly ITherapySessionRepository _therapySessionRepository;
        internal int SelectedTherapySessionId { get; set; }

        private TherapySessionService()
        {
            _therapySessionRepository = new TherapySessionRepository(Database.GetContext());
        }

        internal static TherapySessionService Instance { get; } = new TherapySessionService();


        internal IEnumerable<TherapySession> GetAllTherapySessionsOfPatient(int patientId)
        {
            return _therapySessionRepository.Find(e => e.PatientId == patientId);
        }

        internal IEnumerable<TherapySession> GetAllTherapySessionsOfTherapist(int therapistId)
        {
            return _therapySessionRepository.Find(e => e.TherapistId == therapistId);
        }

        internal void AddTherapySession(TherapySessionDTO therapySessionDTO)
        {
            var therapySession = new TherapySession
            {
                PatientId = therapySessionDTO.Patient.Id,
                TherapistId = UserService.Instance.LoggedInUserId,
                DateTime = therapySessionDTO.DateTime,
                EstimatedDuration = therapySessionDTO.EstimatedDuration
            };
            _therapySessionRepository.Add(therapySession);
            foreach (var treatment in therapySessionDTO.Treatments)
            {
                _therapySessionRepository.AddTreatmentToTherapySession(therapySession,
                    PrescriptionItemService.Instance.GetTreatmentById(treatment.Id));
            }

            _therapySessionRepository.SaveChanges();
        }

        internal IEnumerable<TherapySession> GetTherapySessionsBeforeDate(IEnumerable<TherapySession> therapySessions,
            DateTime date)
        {
            return therapySessions.Where(e => e.DateTime < date);
        }

        internal TherapySession GetSelectedTherapySession()
        {
            return _therapySessionRepository.GetById(SelectedTherapySessionId);
        }

        internal TherapySessionHasTreatments GetTherapySessionHasTreatmentsBySessionIdAndTreatmentId(int sessionId,
            int treatmentId)
        {
            return _therapySessionRepository.GetTherapySessionHasTreatmentsBySessionIdTreatmentId(sessionId,
                treatmentId);
        }

        internal void SaveChanges()
        {
            _therapySessionRepository.SaveChanges();
        }

        internal IEnumerable<Treatment> GetTherapySessionTreatmentsBySessionId(int id)
        {
            return _therapySessionRepository.GetTherapySessionHasTreatmentsEnumerableBySessionId(id)
                .Select(therapySessionTreatment =>
                    PrescriptionItemService.Instance.GetTreatmentById(therapySessionTreatment.TreatmentId)).ToList();
        }

        internal IEnumerable<TherapySession> GetTherapySessionsAtDate(
            IEnumerable<TherapySession> therapySessions, DateTime date)
        {
            return therapySessions.Where(e => e.DateTime.Date == date.Date);
        }
    }
}