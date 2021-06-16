using System;
using System.Collections.Generic;
using System.Linq;
using ComponentsLibrary;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Repositories;
using ComponentsLibrary.Repositories.Implementations;
using ComponentsLibrary.Repositories.Interfaces;

namespace ServicesLibrary.DifferentServices
{
    public class PrescriptionService
    {
        private IPrescriptionRepository _prescriptionRepository;

        private PrescriptionService()
        {
            _prescriptionRepository = new PrescriptionRepository(Database.GetContext());
        }

        internal static PrescriptionService Instance { get; } = new PrescriptionService();

        public IEnumerable<Prescription> GetPrescriptionsOfPatientById(int patientId)
        {
            return _prescriptionRepository.Find(e => e.PatientId == patientId);
        }

        public IEnumerable<Prescription> GetPrescriptionsStartedBeforeDate(IEnumerable<Prescription> prescriptions,
            DateTime date)
        {
            return prescriptions.Where(e => e.StartDate < date);
        }
    }
}