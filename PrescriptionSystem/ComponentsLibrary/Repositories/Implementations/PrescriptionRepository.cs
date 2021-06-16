using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;
using ComponentsLibrary.Repositories.Interfaces;
using System.Collections.Generic;

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

        public void AddPrescriptionItemToPrescription(Prescription prescription, PrescriptionItem item)
        {
            if (prescription.PrescriptionHasPrescriptionItemsCollection == null)
            {
                prescription.PrescriptionHasPrescriptionItemsCollection = new List<PrescriptionHasPrescriptionItems>
                {
                    new PrescriptionHasPrescriptionItems
                    {
                        Prescription = prescription,
                        PrescriptionItem = item
                    }
                };
            }
            else
            {
                prescription.PrescriptionHasPrescriptionItemsCollection.Add(new PrescriptionHasPrescriptionItems
                {
                    Prescription = prescription,
                    PrescriptionItem = item
                });
            }
        }
    }
}