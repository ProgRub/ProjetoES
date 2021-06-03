using ComponentsLibrary;
using ComponentsLibrary.Repositories.Implementations;
using ComponentsLibrary.Repositories.Interfaces;

namespace ServicesLibrary.DifferentServices
{
    public class PrescriptionItemService
    {
        private IMedicineRepository _medicineRepository;
        private IExerciseRepository _exerciseRepository;
        private ITreatmentRepository _treatmentRepository;

        public PrescriptionItemService()
        {
            _medicineRepository = new MedicineRepository(Database.GetContext());
            _exerciseRepository = new ExerciseRepository(Database.GetContext());
            _treatmentRepository = new TreatmentRepository(Database.GetContext());
        }

    }
}