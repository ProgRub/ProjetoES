using System;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using ComponentsLibrary.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ComponentsLibrary.Repositories.Implementations
{
    public class PrescriptionRepository : BaseRepository<Prescription>, IPrescriptionRepository
    {
        private readonly PrescriptionHasItemsRepository _prescriptionHasItemsRepository;
        private readonly PrescriptionHasViewersRepository _prescriptionHasViewersRepository;

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

        public void AddPrescriptionItemToPrescription(Prescription prescription, PrescriptionItem item,
            List<TimeSpan> recommendedTimes)
        {
            if (prescription.PrescriptionHasPrescriptionItemsCollection == null)
            {
                prescription.PrescriptionHasPrescriptionItemsCollection = new List<PrescriptionHasPrescriptionItems>
                {
                    new PrescriptionHasPrescriptionItems
                    {
                        PrescriptionId = prescription.Id,
                        PrescriptionItemId = _context.PrescriptionItems.First(e => e.Id == item.Id).Id,
                        RecommendedTimes = recommendedTimes.Any() ? recommendedTimes : null
                    }
                };
            }
            else
            {
                prescription.PrescriptionHasPrescriptionItemsCollection.Add(new PrescriptionHasPrescriptionItems
                {
                    PrescriptionId = prescription.Id,
                    PrescriptionItemId = _context.PrescriptionItems.First(e => e.Id == item.Id).Id,
                    RecommendedTimes = recommendedTimes.Any() ? recommendedTimes : null
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
                        PrescriptionId = prescription.Id,
                        HealthCareProfessionalId = healthCareProfessional.Id
                    }
                };
            }
            else
            {
                prescription.PrescriptionHasViewersCollection.Add(new PrescriptionHasViewers
                {
                    PrescriptionId = prescription.Id,
                    HealthCareProfessionalId = healthCareProfessional.Id
                });
            }
        }

        public bool IsHealthCareProfessionalPrescriptionViewer(Prescription prescription,
            HealthCareProfessional healthCareProfessional)
        {
            return _prescriptionHasViewersRepository.Find(e =>
                e.HealthCareProfessionalId == healthCareProfessional.Id && e.PrescriptionId == prescription.Id).Any();
        }

        public IEnumerable<PrescriptionHasPrescriptionItems>
            GetPrescriptionHasPrescriptionItemsEnumerableByPrescriptionId(
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