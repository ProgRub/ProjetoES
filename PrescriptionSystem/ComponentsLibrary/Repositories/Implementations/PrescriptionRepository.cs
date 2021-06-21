using System;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using ComponentsLibrary.Repositories.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace ComponentsLibrary.Repositories.Implementations
{
    public class PrescriptionRepository : BaseRepository<Prescription>, IPrescriptionRepository
    {
        private PrescriptionHasItemsRepository _prescriptionHasItemsRepository;
        private PrescriptionHasViewersRepository _prescriptionHasViewersRepository;
        public PrescriptionRepository(PrescriptionSystemDbContext context) : base(context)
        {
            _prescriptionHasItemsRepository = new PrescriptionHasItemsRepository(context);
            _prescriptionHasViewersRepository = new PrescriptionHasViewersRepository(context);
        }

        public new void SaveChanges()
        {
            base.SaveChanges();
            _prescriptionHasViewersRepository.SaveChanges();
            _prescriptionHasItemsRepository.SaveChanges();
        }

        public void AddPrescriptionItemToPrescription(Prescription prescription, PrescriptionItem item, List<TimeSpan> recommendedTime)
        {
            if (prescription.PrescriptionHasPrescriptionItemsCollection == null)
            {
                prescription.PrescriptionHasPrescriptionItemsCollection = new List<PrescriptionHasPrescriptionItems>
                {
                    new PrescriptionHasPrescriptionItems
                    {
                        Prescription = prescription,
                        PrescriptionItem = item,
                        RecommendedTimes = recommendedTime
                    }
                };
            }
            else
            {
                prescription.PrescriptionHasPrescriptionItemsCollection.Add(new PrescriptionHasPrescriptionItems
                {
                    Prescription = prescription,
                    PrescriptionItem = item,
                    RecommendedTimes = recommendedTime
                });
            }
        }

        public void AddViewerToPrescription(Prescription prescription, HealthCareProfessional healthCareProfessional)
        {
            if (prescription.PrescriptionHasViewersCollection == null)
            {
                prescription.PrescriptionHasViewersCollection = new List<PrescriptionHasViewers>
                {
                    new PrescriptionHasViewers()
                    {
                        Prescription = prescription,
                        HealthCareProfessional = healthCareProfessional
                    }
                };
            }
            else
            {
                prescription.PrescriptionHasViewersCollection.Add(new PrescriptionHasViewers
                {
                    Prescription = prescription,
                    HealthCareProfessional = healthCareProfessional
                });
            }
        }

        public bool IsHealthCareProfessionalPrescriptionViewer(Prescription prescription,
            HealthCareProfessional healthCareProfessional)
        {
            return _prescriptionHasViewersRepository.Find(e =>
                e.HealthCareProfessionalId == healthCareProfessional.Id && e.PrescriptionId == prescription.Id).Any();
        }

        public IEnumerable<PrescriptionHasPrescriptionItems> GetPrescriptionHasPrescriptionItemsEnumerable(
            int prescriptionId)
        {
            return _prescriptionHasItemsRepository.Find(e => e.PrescriptionId == prescriptionId);
        }

        public IEnumerable<int> GetPrescriptionViewersIdsByPrescriptionId(int id)
        {
            return _prescriptionHasViewersRepository.Find(e => e.PrescriptionId == id)
                .Select(e => e.HealthCareProfessionalId);
        }
    }
}