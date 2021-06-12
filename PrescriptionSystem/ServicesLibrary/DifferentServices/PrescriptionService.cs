using ComponentsLibrary;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using ComponentsLibrary.Repositories;
using ComponentsLibrary.Repositories.Implementations;
using ComponentsLibrary.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

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

        internal void CreatePrescription(Patient patient, string description, DateTime startDate, DateTime endDate, ICollection<PrescriptionItem> prescriptionItems)
        {

            var prescription = new Prescription
            {
                AuthorId = UserService.Instance.LoggedInUserId,
                PatientId = patient.Id,
                Description = description,
                StartDate = startDate,
                EndDate = endDate
            };

            _prescriptionRepository.Add(prescription);

            foreach (var item in prescriptionItems)
            {
                _prescriptionRepository.AddPrescriptionItemToPrescription(prescription, item);
            }

            _prescriptionRepository.SaveChanges();
        }
    }
}