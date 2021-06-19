using System.Collections.Generic;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;

namespace ComponentsLibrary.Repositories.Interfaces
{
    public interface IPrescriptionRepository : IGenericRepository<Prescription>
    {
        void AddPrescriptionItemToPrescription(Prescription prescription, PrescriptionItem item);
        void AddViewerToPrescription(Prescription prescription, HealthCareProfessional healthCareProfessional);

        bool IsHealthCareProfessionalPrescriptionViewer(Prescription prescription,
            HealthCareProfessional healthCareProfessional);

        IEnumerable<PrescriptionHasPrescriptionItems> GetPrescriptionHasPrescriptionItemsEnumerable(
            int prescriptionId);

        IEnumerable<HealthCareProfessional> GetPrescriptionViewersByPrescriptionId(int id);
    }
}