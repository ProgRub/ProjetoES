using System;
using System.Collections.Generic;
using ComponentsLibrary.Entities;
using ComponentsLibrary.Entities.PrescriptionItems;

namespace ComponentsLibrary.Repositories.Interfaces
{
    public interface IPrescriptionRepository : IGenericRepository<Prescription>
    {
        void AddPrescriptionItemToPrescription(Prescription prescription, PrescriptionItem item,
            List<TimeSpan> recommendedTimes);

        void AddViewerToPrescription(Prescription prescription, HealthCareProfessional healthCareProfessional);

        bool IsHealthCareProfessionalPrescriptionViewer(Prescription prescription,
            HealthCareProfessional healthCareProfessional);

        IEnumerable<PrescriptionHasPrescriptionItems> GetPrescriptionHasPrescriptionItemsEnumerableByPrescriptionId(
            int prescriptionId);

        IEnumerable<int> GetPrescriptionViewersIdsByPrescriptionId(int id);
    }
}