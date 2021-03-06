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
    public class PrescriptionService
    {
        private readonly IPrescriptionRepository _prescriptionRepository;

        private PrescriptionService()
        {
            _prescriptionRepository = new PrescriptionRepository(Database.GetContext());
        }

        internal static PrescriptionService Instance { get; } = new PrescriptionService();

        internal List<Prescription> SelectedPrescriptions { get; set; }

        internal void CreatePrescription(PrescriptionDTO prescriptionDTO)
        {
            var prescription = new Prescription
            {
                AuthorId = prescriptionDTO.Author.Id, PatientId = prescriptionDTO.Patient.Id,
                Description = prescriptionDTO.Description, StartDate = prescriptionDTO.StartDate.Date,
                EndDate = prescriptionDTO.EndDate.Date
            };
            _prescriptionRepository.Add(prescription);
            foreach (var prescriptionItem in prescriptionDTO.PrescriptionItemsRecommendedTimes.Keys)
            {
                _prescriptionRepository.AddPrescriptionItemToPrescription(prescription,
                    PrescriptionItemService.Instance.GetPrescriptionItemById(prescriptionItem.Id),
                    prescriptionDTO.PrescriptionItemsRecommendedTimes[prescriptionItem].ToList());
            }

            _prescriptionRepository.SaveChanges();
        }

        internal IEnumerable<Prescription> GetPrescriptionsOfPatientById(int patientId)
        {
            return _prescriptionRepository.Find(e => e.PatientId == patientId);
        }

        internal IEnumerable<Prescription> GetPrescriptionsStartedBeforeDate(IEnumerable<Prescription> prescriptions,
            DateTime date)
        {
            return prescriptions.Where(e => e.StartDate <= date && e.EndDate >= date);
        }

        internal void AddSelectedPrescriptionById(int id)
        {
            SelectedPrescriptions.Add(_prescriptionRepository.GetById(id));
        }

        internal void AddHealthCareProfessionalAsViewerToPrescription(Prescription prescription,
            HealthCareProfessional healthCareProfessional)
        {
            if (CanHealthCareProfessionalViewPrescription(prescription, healthCareProfessional)) return;
            _prescriptionRepository.AddViewerToPrescription(prescription, healthCareProfessional);
            _prescriptionRepository.SaveChanges();
        }

        internal bool CanHealthCareProfessionalViewPrescription(Prescription prescription,
            HealthCareProfessional healthCareProfessional)
        {
            return prescription.AuthorId == healthCareProfessional.Id ||
                   _prescriptionRepository.IsHealthCareProfessionalPrescriptionViewer(prescription,
                       healthCareProfessional);
        }

        internal IEnumerable<PrescriptionItem> GetPrescriptionItemsOfPrescriptionById(int prescriptionId)
        {
            var prescriptionItems = new List<PrescriptionItem>();
            foreach (var prescriptionHasItems in _prescriptionRepository
                .GetPrescriptionHasPrescriptionItemsEnumerableByPrescriptionId(
                    prescriptionId))
            {
                if (PrescriptionItemService.Instance.IsExercise(prescriptionHasItems.PrescriptionItemId))
                {
                    prescriptionItems.Add(
                        PrescriptionItemService.Instance.GetExerciseById(prescriptionHasItems.PrescriptionItemId));
                }
                else if (PrescriptionItemService.Instance.IsMedicine(prescriptionHasItems.PrescriptionItemId))
                {
                    prescriptionItems.Add(
                        PrescriptionItemService.Instance.GetMedicineById(prescriptionHasItems.PrescriptionItemId));
                }
                else
                {
                    prescriptionItems.Add(
                        PrescriptionItemService.Instance.GetTreatmentById(prescriptionHasItems.PrescriptionItemId));
                }
            }

            return prescriptionItems;
        }

        internal IEnumerable<HealthCareProfessional> GetPrescriptionViewersByPrescriptionId(int id)
        {
            return _prescriptionRepository.GetPrescriptionViewersIdsByPrescriptionId(id)
                .Select(e => HealthCareProfessionalService.Instance.GetById(e));
        }

        internal Prescription GetPrescriptionById(int prescriptionId)
        {
            return _prescriptionRepository.GetById(prescriptionId);
        }

        internal IEnumerable<TimeSpan> GetPrescriptionItemRecommendedTimesByPrescriptionIdAndItemId(int prescriptionID,
            int prescriptionItemId)
        {
            return _prescriptionRepository.GetPrescriptionHasPrescriptionItemsEnumerableByPrescriptionId(prescriptionID)
                .First(e => e.PrescriptionItemId == prescriptionItemId).RecommendedTimes;
        }
    }
}